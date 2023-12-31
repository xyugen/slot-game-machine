﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotGameMachine
{
    /// <summary>
    /// Custom MessageBox form for displaying custom messages.
    /// </summary>
    public partial class cMessBox : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="cMessBox"/> class.
        /// </summary>
        public cMessBox()
        {
            InitializeComponent();
            this.Size = new(280, 200);
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.SizeGripStyle = SizeGripStyle.Hide;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            btnConfirm.Left = (this.ClientSize.Width - btnConfirm.Width) / 2;
        }

        /// <summary>
        /// Displays the custom MessageBox dialog with the specified title and icon.
        /// </summary>
        /// <param name="title">The title of the dialog.</param>
        /// <param name="icon">The icon to be displayed in the dialog.</param>
        public void ShowDialog(string title, Icon icon)
        {
            this.Text = title;
            this.Icon = icon;

            ShowDialog();
        }

        /// <summary>
        /// Handles the "Confirm" button click event and closes the dialog.
        /// </summary>
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the LinkLabel LinkClicked event and opens the specified URL in the default browser.
        /// </summary>
        private void LnkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.github.com/xyugen/";

            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }
    }
}
