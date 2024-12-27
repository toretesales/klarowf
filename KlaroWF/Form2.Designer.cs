namespace KlaroWF
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            linkMPL2 = new LinkLabel();
            linkVictorvde = new LinkLabel();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.about;
            pictureBox1.Location = new Point(27, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(428, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(251, 251, 251);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(linkMPL2);
            panel1.Controls.Add(linkVictorvde);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 217);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(12);
            panel1.Size = new Size(482, 436);
            panel1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ic_fluent_open_24_filled;
            pictureBox2.Location = new Point(31, 323);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(16, 16);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // linkMPL2
            // 
            linkMPL2.LinkBehavior = LinkBehavior.HoverUnderline;
            linkMPL2.Location = new Point(27, 209);
            linkMPL2.Name = "linkMPL2";
            linkMPL2.Size = new Size(201, 20);
            linkMPL2.TabIndex = 12;
            linkMPL2.TabStop = true;
            linkMPL2.Text = "https://mozilla.org/MPL/2.0/.";
            linkMPL2.TextAlign = ContentAlignment.MiddleCenter;
            linkMPL2.LinkClicked += linkMPL2_LinkClicked;
            // 
            // linkVictorvde
            // 
            linkVictorvde.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkVictorvde.LinkBehavior = LinkBehavior.NeverUnderline;
            linkVictorvde.Location = new Point(53, 319);
            linkVictorvde.Name = "linkVictorvde";
            linkVictorvde.Size = new Size(164, 20);
            linkVictorvde.TabIndex = 11;
            linkVictorvde.TabStop = true;
            linkVictorvde.Text = "jpeg2png Github Page";
            linkVictorvde.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(27, 363);
            label3.Name = "label3";
            label3.Size = new Size(363, 49);
            label3.TabIndex = 10;
            label3.Text = "Development and artwork by Toretesales\r\nwith iconography sourced form Fluenticons.co";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(27, 122);
            label1.Name = "label1";
            label1.Size = new Size(428, 92);
            label1.TabIndex = 9;
            label1.Text = "This software is distributed without warranty or liability.\r\n\r\nThe source code for this application is under the Mozilla Public License V2.0. To know more about the MPL, please visit:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 27);
            label2.Name = "label2";
            label2.Size = new Size(428, 62);
            label2.TabIndex = 8;
            label2.Text = "v1.0.0\r\nAn absolutely dead basic graphical user interface wrapper for Jpeg2png.";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 243, 243);
            ClientSize = new Size(482, 653);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            Padding = new Padding(24);
            StartPosition = FormStartPosition.CenterParent;
            Text = "About Me";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel1;
        private LinkLabel linkVictorvde;
        private Label label3;
        private Label label1;
        private Label label2;
        private LinkLabel linkMPL2;
        private PictureBox pictureBox2;
    }
}