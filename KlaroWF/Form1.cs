// This Source Code Form is subject to the terms of the Mozilla Public License, 
// v. 2.0. If a copy of the MPL was not distributed with this file,
// You can obtain one at https://mozilla.org/MPL/2.0/.


using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing;

namespace KlaroWF
{
    public partial class Form1 : Form
    {

        private List<string> selectedFiles = new List<string>();  // Add this at the class level

        public Form1()
        {
            InitializeComponent();

            // Hook up event handlers for button clicks
            btnSelectPhoto.Click += btnSelectPhoto_Click;
            btnSelectFolder.Click += btnSelectFolder_Click;
            btnConvert.Click += BtnConvert_Click;  // Call to BtnConvert_Click when the button is clicked
            LoadPreviousSettings();

            // Subscribe to the FormClosing event
            this.FormClosing += Form1_FormClosing;
        }

        private string configFilePath = "config.txt";

        // Load the last output folder from the configuration file
        private string LoadLastOutputFolder()
        {
            if (File.Exists(configFilePath))
            {
                // Read the file content
                string content = File.ReadAllText(configFilePath).Trim();

                // Return the content if it's valid
                if (!string.IsNullOrEmpty(content))
                {
                    return content;
                }
            }

            // Return empty string if file doesn't exist or is empty
            return string.Empty;
        }


        // Save the selected output folder to the configuration file
        private void SaveLastOutputFolder(string folderPath)
        {
            // Overwrite or create the config file with the new folder path
            File.WriteAllText(configFilePath, folderPath);
        }


        // Handler for disabling btnConvert until image and folder is selected
        private void UpdateConvertButtonState()

        {
            // Enable btnConvert only if both photo and folder paths are set
            btnConvert.Enabled = !string.IsNullOrWhiteSpace(lblFilePath.Text) &&
                                 !string.IsNullOrWhiteSpace(lblFolderPath.Text);
        }

        // Handler for btnSelectPhoto click (select image)
        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            // Initialize the OpenFileDialog for selecting image files
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JPEG Files|*.jpg;*.jpeg";  // Filter for .jpg and .jpeg files
                openFileDialog.Title = "Select Image Files";  // Title of the dialog
                openFileDialog.Multiselect = true;  // Allow multi-file selection

                // If the user selects files
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Clear the selected files list first
                    selectedFiles.Clear();

                    // Add selected files to the list
                    selectedFiles.AddRange(openFileDialog.FileNames);

                    // Update the display label for file paths and selected image count
                    if (selectedFiles.Count > 1)
                    {
                        lblSelectedImage.Text = "More than one file is selected";  // More than one file selected
                        lblFilePath.Text = $"{selectedFiles.Count} files selected";  // Display the number of files selected
                    }
                    else
                    {
                        lblSelectedImage.Text = Path.GetFileName(openFileDialog.FileName);  // Display single file name
                        lblFilePath.Text = openFileDialog.FileName;  // Show the file path for the single image
                    }

                    // Call method to update the preview display with selected files (now using FlowLayoutPanel or PictureBox)
                    UpdatePreviewDisplay(selectedFiles);  // This will handle displaying images in the appropriate UI element
                }
            }

            // Enable or update the Convert button
            UpdateConvertButtonState();
        }




        private async void ProcessBatchConversions(string outputFolder)
        {
            // Loop through each selected image
            foreach (string inputFile in selectedFiles)
            {
                string outputFileName = Path.Combine(outputFolder, Path.GetFileNameWithoutExtension(inputFile) + ".png");

                // Define a temporary directory to store the copied .jpg for conversion
                string tempDirectory = Path.Combine(Application.StartupPath, "temp");
                if (!Directory.Exists(tempDirectory))
                {
                    Directory.CreateDirectory(tempDirectory);
                }

                // Copy the selected .jpg file to the temporary directory
                string tempInputFilePath = Path.Combine(tempDirectory, Path.GetFileName(inputFile));
                File.Copy(inputFile, tempInputFilePath, true);

                // Run the conversion asynchronously for this file
                await Task.Run(() =>
                {
                    RunJpeg2PngAsync(tempInputFilePath, outputFolder);
                });
            }
        }

        private void UpdatePreviewDisplay(List<string> selectedFiles)
        {
            // Clear existing images from FlowLayoutPanel
            flpImagePreview.Controls.Clear();  // Assuming 'flpImagePreview' is your FlowLayoutPanel

            // Set FlowLayoutPanel properties to allow wrapping
            flpImagePreview.FlowDirection = FlowDirection.LeftToRight;  // Align left to right
            flpImagePreview.WrapContents = true;  // Automatically wrap when items exceed panel width

            // Set padding for more space between images
            flpImagePreview.Padding = new Padding(10);

            // Loop through selected files and add them to FlowLayoutPanel
            foreach (var file in selectedFiles)
            {
                // Create PictureBox for each image
                PictureBox picBox = new PictureBox
                {
                    Width = 145,  // Set PictureBox width
                    Height = 148, // Set PictureBox height
                    SizeMode = PictureBoxSizeMode.Zoom,  // Use Zoom to keep image proportions
                    Image = Image.FromFile(file)  // Load the image from file path
                };

                // Add PictureBox to FlowLayoutPanel
                flpImagePreview.Controls.Add(picBox);
            }
        }


        // Handler for btnSelectFolder click (select output folder)
        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select an Output Folder";

                // Preselect the last folder if available
                string lastFolder = LoadLastOutputFolder();
                if (Directory.Exists(lastFolder))
                {
                    folderBrowserDialog.SelectedPath = lastFolder;
                }

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    lblFolderPath.Text = folderBrowserDialog.SelectedPath;
                    lblFolderName.Text = Path.GetFileName(folderBrowserDialog.SelectedPath);

                    // Save the selected folder to config immediately
                    SaveLastOutputFolder(folderBrowserDialog.SelectedPath);
                }
            }

            UpdateConvertButtonState(); // Ensure button state updates correctly
        }

        private void LoadPreviousSettings()
        {
            string lastFolder = LoadLastOutputFolder();
            if (Directory.Exists(lastFolder))
            {
                lblFolderPath.Text = lastFolder;
                lblFolderName.Text = Path.GetFileName(lastFolder);
                UpdateConvertButtonState(); // Enable Convert button if everything is valid
            }
        }

        // Execute the jpeg2png conversion when the Convert button is clicked
        private void BtnConvert_Click(object sender, EventArgs e)
        {
            string outputFolder = lblFolderPath.Text;

            // Validate if at least one image is selected
            if (selectedFiles == null || selectedFiles.Count == 0)
            {
                MessageBox.Show("Please select at least one valid image file.", "No Image Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // Exit if no file is selected
            }

            // Validate the output folder
            if (string.IsNullOrEmpty(outputFolder) || !Directory.Exists(outputFolder))
            {
                MessageBox.Show("Please select a valid output folder.", "Invalid Output", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // Exit if the folder isn't valid
            }

            // Loop through the selected files and run the conversion for each file
            foreach (var inputFile in selectedFiles)
            {
                if (!File.Exists(inputFile))  // Validate each selected file
                {
                    MessageBox.Show($"File '{inputFile}' does not exist or is invalid.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;  // Skip the current file and continue with the next one
                }

                // Call the method to run jpeg2png for the current file
                RunJpeg2PngAsync(inputFile, outputFolder);
            }
        }


        // Add a delay for Klaro to move the converted file to the desired directory
        private async Task<bool> WaitForFileAsync(string filePath, int timeoutMilliseconds = 8000, int checkInterval = 200)
        {
            int elapsed = 0;
            while (elapsed < timeoutMilliseconds)
            {
                if (File.Exists(filePath))
                {
                    return true; // File exists, return success
                }

                // Wait for the interval before checking again
                await Task.Delay(checkInterval);
                elapsed += checkInterval;
            }

            return false; // Timed out
        }

        // Wait for the file to be accessible before Klaro can modify it
        private async Task<bool> WaitForFileAccessibleAsync(string filePath, int timeoutMilliseconds = 5000, int checkInterval = 200)
        {
            int elapsed = 0;
            while (elapsed < timeoutMilliseconds)
            {
                try
                {
                    // Check if the file exists and is not locked
                    if (File.Exists(filePath))
                    {
                        using (FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            return true; // File exists and is accessible
                        }
                    }
                }
                catch (IOException)
                {
                    // File is still locked, continue to wait
                }

                // Wait for the interval before checking again
                await Task.Delay(checkInterval);
                elapsed += checkInterval;
            }

            return false; // Timed out
        }

        private async Task<bool> WaitForFileReadyAsync(string filePath, int timeoutMilliseconds = 10000, int checkInterval = 200)
        {
            int elapsed = 0;
            while (elapsed < timeoutMilliseconds)
            {
                try
                {
                    // Check if the file exists and is ready (not locked)
                    if (File.Exists(filePath))
                    {
                        using (FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            return true; // File exists and is ready
                        }
                    }
                }
                catch (IOException)
                {
                    // File is still locked, continue checking
                }

                await Task.Delay(checkInterval); // Wait and retry
                elapsed += checkInterval;
            }

            return false; // Timed out
        }


        // Keeps track of the current progress line index
        private int progressBarLineIndex = -1;

        private async void RunJpeg2PngAsync(string inputFile, string outputFolder)
        {
            // Ensure the input file is a valid JPEG file (we'll now handle both uppercase and lowercase extensions)
            string fileExtension = Path.GetExtension(inputFile).ToLower();
            if (fileExtension != ".jpg" && fileExtension != ".jpeg")
            {
                MessageBox.Show("Please select a valid JPEG file (with .jpg or .jpeg extension).", "Invalid File Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Define a temporary directory for conversion (inside the application directory)
            string tempDirectory = Path.Combine(Application.StartupPath, "temp");

            if (!Directory.Exists(tempDirectory))
            {
                Directory.CreateDirectory(tempDirectory); // Make sure temp directory exists
            }

            // Normalize the input filename by converting it to lowercase (helps avoid issues with uppercase extensions)
            string inputFileNormalized = inputFile.ToLower();

            // Prepare a temporary path for the input image in the temp directory
            string tempInputFilePath = Path.Combine(tempDirectory, Path.GetFileName(inputFileNormalized));

            // Copy the selected .jpg file to the temporary directory for processing
            File.Copy(inputFile, tempInputFilePath, true);

            // Prepare the final output file path (should be in output folder)
            string outputFile = Path.Combine(outputFolder, Path.GetFileNameWithoutExtension(inputFileNormalized) + ".png");

            // Show terminal output (optional)
            richTextBoxTerminal.Visible = true;
            richTextBoxTerminal.Clear(); // Clear existing output

            // Run the conversion asynchronously
            await Task.Run(() =>
            {
                // Set up the ProcessStartInfo for jpeg2png.exe
                ProcessStartInfo processStartInfo = new ProcessStartInfo()
                {
                    FileName = "jpeg2png", // Assume jpeg2png is in the app folder
                    Arguments = $"\"{Path.GetFileName(tempInputFilePath)}\"",
                    WorkingDirectory = tempDirectory, // Working directory should be where jpeg2png is located
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                // Handle output and error data asynchronously
                using (Process process = Process.Start(processStartInfo))
                {
                    process.OutputDataReceived += (sender, args) =>
                    {
                        if (!string.IsNullOrEmpty(args.Data))
                        {
                            Invoke(new Action(() =>
                            {
                                if (args.Data.StartsWith("[") && args.Data.EndsWith("%")) // Detect progress bar lines
                                {
                                    UpdateProgressBarInRichTextBox(args.Data); // Update progress bar
                                }
                                else
                                {
                                    AppendTerminalOutput(args.Data); // Append other output normally
                                }
                            }));
                        }
                    };

                    // Start reading output and errors asynchronously
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();

                    try
                    {
                        // Wait for the process to complete 
                        process.WaitForExit();

                        // After the conversion, check if the .png file was created in the temp directory
                        string convertedFile = Path.Combine(tempDirectory, Path.GetFileNameWithoutExtension(inputFileNormalized) + ".png");
                        if (File.Exists(convertedFile))
                        {
                            try
                            {
                                // Move the converted file to the specified output folder
                                File.Move(convertedFile, outputFile);
                                Invoke(new Action(() =>
                                {
                                    richTextBoxTerminal.AppendText($"{Environment.NewLine}File successfully moved to:{outputFile}{Environment.NewLine}");
                                }));
                            }
                            catch (Exception moveEx)
                            {
                                Invoke(new Action(() =>
                                {
                                    richTextBoxTerminal.AppendText($"{Environment.NewLine}Error moving file: {moveEx.Message}{Environment.NewLine}");
                                }));
                            }
                        }
                        else
                        {
                            Invoke(new Action(() =>
                            {
                                richTextBoxTerminal.AppendText($"{Environment.NewLine}Conversion failed. No PNG file created.{Environment.NewLine}");
                            }));
                        }
                    }
                    catch (Exception ex)
                    {
                        Invoke(new Action(() =>
                        {
                            richTextBoxTerminal.AppendText($"{Environment.NewLine}Error executing jpeg2png: {ex.Message}{Environment.NewLine}");
                        }));
                    }
                    finally
                    {
                        // Clean up: Delete the copied JPEG from the temporary directory
                        if (File.Exists(tempInputFilePath))
                        {
                            File.Delete(tempInputFilePath);
                        }
                        Invoke(new Action(() =>
                        {
                            richTextBoxTerminal.AppendText($"{Environment.NewLine}Conversion finished.{Environment.NewLine}");
                        }));
                    }
                }
            });
        }

        // Method to update the progress bar in RichTextBox
        private void UpdateProgressBarInRichTextBox(string progressBarText)
        {
            const int progressBarWidth = 30; // Set a fixed width for the progress bar

            // Ensure progress bar text conforms to the fixed width
            string[] parts = progressBarText.Split(']');
            string bar = parts[0] + "]";

            // Truncate or pad the bar to match the progressBarWidth
            if (bar.Length > progressBarWidth)
            {
                bar = bar.Substring(0, progressBarWidth); // Truncate if too long
            }
            else
            {
                bar = bar.PadRight(progressBarWidth, ' '); // Pad if too short
            }

            string formattedText = bar + " " + parts[1]; // Combine bar with percentage or progress details

            // Ensure we only update the progress bar line
            if (progressBarLineIndex >= 0 && progressBarLineIndex < richTextBoxTerminal.Lines.Length)
            {
                string[] lines = richTextBoxTerminal.Lines;
                lines[progressBarLineIndex] = formattedText;
                richTextBoxTerminal.Lines = lines;
            }
            else
            {
                // If progress bar line doesn't exist, add it
                richTextBoxTerminal.AppendText(formattedText + Environment.NewLine);
                progressBarLineIndex = richTextBoxTerminal.Lines.Length - 1; // Remember the line index
            }

            richTextBoxTerminal.ScrollToCaret(); // Ensure latest update is visible
        }


        // Method to append regular text to the terminal
        private void AppendTerminalOutput(string text)
        {
            richTextBoxTerminal.AppendText(text + Environment.NewLine);

            // Reset progressBarLineIndex if new text interrupts progress bar
            progressBarLineIndex = -1;
        }



        private void CleanupTempFolder(string tempFolderPath)
        {
            try
            {
                if (Directory.Exists(tempFolderPath))
                {
                    Directory.Delete(tempFolderPath, true); // true to delete subdirectories and files
                }
            }
            catch (Exception ex)
            {
                // Log or notify the user of the failure to clean up
                MessageBox.Show($"Failed to clean up temp folder: {ex.Message}", "Cleanup Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Handle the FormClosing event to clear the temp folder
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string tempDirectory = Path.Combine(Application.StartupPath, "temp");

            // Check if the temp folder exists
            if (Directory.Exists(tempDirectory))
            {
                // Get all files in the temp directory
                string[] tempFiles = Directory.GetFiles(tempDirectory);

                // Delete each file in the temp folder
                foreach (var file in tempFiles)
                {
                    try
                    {
                        File.Delete(file); // Try to delete the file
                    }
                    catch (Exception ex)
                    {
                        // If any error occurs, show a warning (optional)
                        MessageBox.Show($"Error deleting temporary file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenTemp_Click(object sender, EventArgs e)
        {
            NoticeForm form3 = new NoticeForm();
            form3.ShowDialog();
        }

        private void linkAbtKlaro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutForm form2 = new AboutForm();
            form2.ShowDialog();
        }
    }
}
