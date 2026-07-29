using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NEA_PROJECT
{
    public partial class PlayerCreator : Form
    {
        public PlayerCreator()
        {
            InitializeComponent();
        }

        private void Male_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            AshBorn player = new AshBorn();
            player.Gender = "Male";
        }

        private void Female_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            AshBorn player = new AshBorn();
            player.Gender = "Female";
        }
    }
}
