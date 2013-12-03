using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SandwichMaker2
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            SettingsContainer.Location = new Point((Screen.PrimaryScreen.Bounds.Width - SettingsContainer.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - SettingsContainer.Height) / 2);
            OkButton.Location = new Point((SettingsContainer.Width - OkButton.Width - 20), (SettingsContainer.Height - OkButton.Height - 20));
            CancelButton.Location = new Point((SettingsContainer.Width - OkButton.Width - CancelButton.Width - 40), (SettingsContainer.Height - CancelButton.Height - 20));

            //SettingsLayoutTable
        }

        private void OkClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
