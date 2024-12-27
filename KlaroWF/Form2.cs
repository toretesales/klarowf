// This Source Code Form is subject to the terms of the Mozilla Public License, 
// v. 2.0. If a copy of the MPL was not distributed with this file,
// You can obtain one at https://mozilla.org/MPL/2.0/.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace KlaroWF
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // The URL to open
                string url = "https://github.com/victorvde/jpeg2png";

                // Launch the default web browser to open the URL
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                // Handle errors (e.g., no default browser installed)
                MessageBox.Show($"Failed to open the link. Error: {ex.Message}");
            }
        }

        private void linkMPL2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // The URL to open
                string url = "https://mozilla.org/MPL/2.0/";

                // Launch the default web browser to open the URL
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                // Handle errors (e.g., no default browser installed)
                MessageBox.Show($"Failed to open the link. Error: {ex.Message}");
            }
        }
    }
}
