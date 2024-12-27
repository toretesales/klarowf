using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlaroWF
{
    public partial class NoticeForm : Form
    {
        public NoticeForm()
        {
            InitializeComponent();
        }

        private void lblSelectedImage_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmOpen_Click(object sender, EventArgs e)
        {
            string tempDirectory = Path.Combine(Application.StartupPath, "temp");

            try
            {
                // Ensure the directory exists
                if (!Directory.Exists(tempDirectory))
                {
                    Directory.CreateDirectory(tempDirectory); // Create it if it doesn't exist
                }

                // Open the temp directory in the file explorer
                Process.Start(new ProcessStartInfo()
                {
                    FileName = tempDirectory,
                    UseShellExecute = true, // Use the system's default file explorer
                    Verb = "open" // Open the folder
                });

                this.Close();
            }
            catch (Exception ex)
            {
                // Handle any errors that might occur
                MessageBox.Show($"An error occurred while trying to open the temp folder: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void NoticeForm_Load(object sender, EventArgs e)
        {
            btnConfirmOpen.Focus();
        }
    }
}
