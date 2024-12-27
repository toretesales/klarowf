namespace KlaroWF
{
    partial class NoticeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoticeForm));
            lblNotice = new Label();
            lblFilePath = new Label();
            panel1 = new Panel();
            btnConfirmOpen = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNotice
            // 
            lblNotice.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNotice.Location = new Point(27, 24);
            lblNotice.Name = "lblNotice";
            lblNotice.Size = new Size(147, 37);
            lblNotice.TabIndex = 3;
            lblNotice.Text = "What's this?";
            lblNotice.Click += lblSelectedImage_Click;
            // 
            // lblFilePath
            // 
            lblFilePath.Location = new Point(27, 72);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(428, 184);
            lblFilePath.TabIndex = 5;
            lblFilePath.Text = resources.GetString("lblFilePath.Text");
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 251, 251);
            panel1.Controls.Add(btnConfirmOpen);
            panel1.Location = new Point(0, 286);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(16);
            panel1.Size = new Size(481, 107);
            panel1.TabIndex = 6;
            // 
            // btnConfirmOpen
            // 
            btnConfirmOpen.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnConfirmOpen.Location = new Point(322, 31);
            btnConfirmOpen.Name = "btnConfirmOpen";
            btnConfirmOpen.Size = new Size(133, 44);
            btnConfirmOpen.TabIndex = 4;
            btnConfirmOpen.Text = "Open Folder";
            btnConfirmOpen.UseVisualStyleBackColor = true;
            btnConfirmOpen.Click += btnConfirmOpen_Click;
            // 
            // NoticeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 243, 243);
            ClientSize = new Size(482, 393);
            Controls.Add(panel1);
            Controls.Add(lblFilePath);
            Controls.Add(lblNotice);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(500, 440);
            MinimizeBox = false;
            MinimumSize = new Size(500, 440);
            Name = "NoticeForm";
            Padding = new Padding(24);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Notice";
            Load += NoticeForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblNotice;
        private Label lblFilePath;
        private Panel panel1;
        private Button btnConfirmOpen;
    }
}