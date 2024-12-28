namespace KlaroWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblSelectedImage = new Label();
            btnSelectPhoto = new Button();
            lblFilePath = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            linkOpenCurrentFolder = new LinkLabel();
            pictureBox2 = new PictureBox();
            btnSelectFolder = new Button();
            lblFolderPath = new Label();
            lblFolderName = new Label();
            btnConvert = new Button();
            Iconography = new ImageList(components);
            richTextBoxTerminal = new RichTextBox();
            flpImagePreview = new FlowLayoutPanel();
            linkAbtKlaro = new LinkLabel();
            linkLabel1 = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblSelectedImage
            // 
            lblSelectedImage.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectedImage.Location = new Point(69, 20);
            lblSelectedImage.Name = "lblSelectedImage";
            lblSelectedImage.Size = new Size(509, 36);
            lblSelectedImage.TabIndex = 2;
            lblSelectedImage.Text = "No Selected Images";
            lblSelectedImage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSelectPhoto
            // 
            btnSelectPhoto.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSelectPhoto.Location = new Point(445, 139);
            btnSelectPhoto.Name = "btnSelectPhoto";
            btnSelectPhoto.Size = new Size(133, 44);
            btnSelectPhoto.TabIndex = 3;
            btnSelectPhoto.Text = "Select Image";
            btnSelectPhoto.UseVisualStyleBackColor = true;
            // 
            // lblFilePath
            // 
            lblFilePath.Location = new Point(22, 151);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(391, 20);
            lblFilePath.TabIndex = 4;
            lblFilePath.Text = "Select at least one";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 251, 251);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnSelectPhoto);
            panel1.Controls.Add(lblFilePath);
            panel1.Controls.Add(lblSelectedImage);
            panel1.Location = new Point(532, 72);
            panel1.Margin = new Padding(12);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(12);
            panel1.Size = new Size(593, 198);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.im;
            pictureBox1.Location = new Point(15, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(251, 251, 251);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(linkOpenCurrentFolder);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(btnSelectFolder);
            panel2.Controls.Add(lblFolderPath);
            panel2.Controls.Add(lblFolderName);
            panel2.Location = new Point(532, 286);
            panel2.Margin = new Padding(12);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(12);
            panel2.Size = new Size(593, 198);
            panel2.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.fo;
            pictureBox3.Location = new Point(15, 15);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // linkOpenCurrentFolder
            // 
            linkOpenCurrentFolder.ActiveLinkColor = Color.DarkBlue;
            linkOpenCurrentFolder.AutoSize = true;
            linkOpenCurrentFolder.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkOpenCurrentFolder.LinkBehavior = LinkBehavior.NeverUnderline;
            linkOpenCurrentFolder.LinkColor = Color.DarkBlue;
            linkOpenCurrentFolder.Location = new Point(47, 151);
            linkOpenCurrentFolder.Name = "linkOpenCurrentFolder";
            linkOpenCurrentFolder.Size = new Size(150, 20);
            linkOpenCurrentFolder.TabIndex = 12;
            linkOpenCurrentFolder.TabStop = true;
            linkOpenCurrentFolder.Text = "Open selected folder";
            linkOpenCurrentFolder.TextAlign = ContentAlignment.MiddleLeft;
            linkOpenCurrentFolder.LinkClicked += linkOpenCurrentFolder_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.re;
            pictureBox2.Location = new Point(22, 151);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSelectFolder.Location = new Point(445, 139);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new Size(133, 44);
            btnSelectFolder.TabIndex = 3;
            btnSelectFolder.Text = "Select Folder";
            btnSelectFolder.UseVisualStyleBackColor = true;
            // 
            // lblFolderPath
            // 
            lblFolderPath.Location = new Point(15, 78);
            lblFolderPath.Name = "lblFolderPath";
            lblFolderPath.Size = new Size(556, 20);
            lblFolderPath.TabIndex = 4;
            lblFolderPath.Text = "Please select a folder";
            // 
            // lblFolderName
            // 
            lblFolderName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFolderName.Location = new Point(69, 23);
            lblFolderName.Name = "lblFolderName";
            lblFolderName.Size = new Size(509, 32);
            lblFolderName.TabIndex = 2;
            lblFolderName.Text = "No Folder for Converted Images";
            lblFolderName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnConvert
            // 
            btnConvert.BackColor = Color.FromArgb(251, 251, 251);
            btnConvert.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConvert.ForeColor = SystemColors.ControlText;
            btnConvert.ImageIndex = 0;
            btnConvert.ImageList = Iconography;
            btnConvert.Location = new Point(977, 15);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(148, 44);
            btnConvert.TabIndex = 5;
            btnConvert.Text = "Convert";
            btnConvert.TextAlign = ContentAlignment.MiddleRight;
            btnConvert.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConvert.UseVisualStyleBackColor = false;
            // 
            // Iconography
            // 
            Iconography.ColorDepth = ColorDepth.Depth32Bit;
            Iconography.ImageStream = (ImageListStreamer)resources.GetObject("Iconography.ImageStream");
            Iconography.TransparentColor = Color.Transparent;
            Iconography.Images.SetKeyName(0, "ic_fluent_flash_on_24_filled.png");
            Iconography.Images.SetKeyName(1, "ic_fluent_folder_open_24_filled.png");
            Iconography.Images.SetKeyName(2, "fo.png");
            Iconography.Images.SetKeyName(3, "del.png");
            // 
            // richTextBoxTerminal
            // 
            richTextBoxTerminal.BackColor = Color.FromArgb(80, 80, 80);
            richTextBoxTerminal.BorderStyle = BorderStyle.None;
            richTextBoxTerminal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxTerminal.ForeColor = SystemColors.Control;
            richTextBoxTerminal.Location = new Point(532, 499);
            richTextBoxTerminal.Name = "richTextBoxTerminal";
            richTextBoxTerminal.ReadOnly = true;
            richTextBoxTerminal.Size = new Size(593, 159);
            richTextBoxTerminal.TabIndex = 9;
            richTextBoxTerminal.Text = "";
            // 
            // flpImagePreview
            // 
            flpImagePreview.AutoScroll = true;
            flpImagePreview.BackColor = Color.FromArgb(235, 235, 235);
            flpImagePreview.FlowDirection = FlowDirection.TopDown;
            flpImagePreview.Location = new Point(15, 15);
            flpImagePreview.Name = "flpImagePreview";
            flpImagePreview.Padding = new Padding(12);
            flpImagePreview.Size = new Size(502, 643);
            flpImagePreview.TabIndex = 12;
            flpImagePreview.WrapContents = false;
            // 
            // linkAbtKlaro
            // 
            linkAbtKlaro.ActiveLinkColor = SystemColors.ControlText;
            linkAbtKlaro.AutoSize = true;
            linkAbtKlaro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkAbtKlaro.LinkBehavior = LinkBehavior.HoverUnderline;
            linkAbtKlaro.LinkColor = SystemColors.ControlText;
            linkAbtKlaro.Location = new Point(532, 20);
            linkAbtKlaro.Name = "linkAbtKlaro";
            linkAbtKlaro.Size = new Size(58, 28);
            linkAbtKlaro.TabIndex = 13;
            linkAbtKlaro.TabStop = true;
            linkAbtKlaro.Text = "Klaro";
            linkAbtKlaro.LinkClicked += linkAbtKlaro_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.DarkBlue;
            linkLabel1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = Color.DarkBlue;
            linkLabel1.ImageKey = "fo.png";
            linkLabel1.ImageList = Iconography;
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkColor = Color.DarkBlue;
            linkLabel1.Location = new Point(755, 23);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(206, 25);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Open Temp";
            linkLabel1.TextAlign = ContentAlignment.MiddleRight;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 243, 243);
            ClientSize = new Size(1140, 673);
            Controls.Add(linkLabel1);
            Controls.Add(linkAbtKlaro);
            Controls.Add(flpImagePreview);
            Controls.Add(richTextBoxTerminal);
            Controls.Add(btnConvert);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1200, 720);
            MinimizeBox = false;
            MinimumSize = new Size(800, 720);
            Name = "Form1";
            Padding = new Padding(12);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KlaroWF";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSelectedImage;
        private Button btnSelectPhoto;
        private Label lblFilePath;
        private Panel panel1;
        private Panel panel2;
        private Button btnSelectFolder;
        private Label lblFolderPath;
        private Label lblFolderName;
        private Button btnConvert;
        private RichTextBox richTextBoxTerminal;
        private ImageList Iconography;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private FlowLayoutPanel flpImagePreview;
        private LinkLabel linkAbtKlaro;
        private LinkLabel linkOpenCurrentFolder;
        private PictureBox pictureBox3;
        private LinkLabel linkLabel1;
    }
}
