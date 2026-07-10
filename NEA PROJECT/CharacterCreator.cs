using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NEA_PROJECT
{
    public partial class CharacterCreator : Form
    {
        public CharacterCreator()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AshenVeil mainmenu = new AshenVeil();
            mainmenu.Show();
            this.Close();
        }
    }
}
