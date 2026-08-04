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
        public static AshBorn Player = CharacterCreator.Player; //Carries over the saved character from CharacterCreator

        public PlayerCreator()
        {
            InitializeComponent();
        }

        private void Male_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
            Player.Gender = "Male";
        }

        private void Female_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            Player.Gender = "Female";
        }

        private void Name_TextBox_TextChanged(object sender, EventArgs e)
        {
            Player.Name = Name_TextBox.Text;
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Character Created Successfully!");
            CharacterDisplay display = new CharacterDisplay();
            display.Show();
            this.Close();
            
        }
    }
}
