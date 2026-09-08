using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NEA_PROJECT
{
    public partial class CombatForm : Form
    {
        public CombatForm()
        {
            InitializeComponent();
        }

        private void Combat_Button_Click(object sender, EventArgs e)
        {
            Display_Panel.Controls.Clear();
        }

        private void Display_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
