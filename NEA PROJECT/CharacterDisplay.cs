using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NEA_PROJECT
{
    public partial class CharacterDisplay : Form
    {
        public AshBorn Player = PlayerCreator.Player; //Carries over the saved character from CharacterCreator
        public CharacterDisplay()
        {
            InitializeComponent();

            Display_Panel.Text = $"Character Information:\r\nName: {Player.Name} the {Player.classname}\r\nGender: {Player.Gender}\r\nHealth: {Player.Vigor}\r\nMana: {Player.CurrentMana}\r\nStrength: {Player.Strength}\r\nMind: {Player.Mind}\r\nEndurance: {Player.Endurance}\r\nSpeed: {Player.Speed}";
        }

        private void Display_Panel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CharacterCreator CharacterCreator = new CharacterCreator();
            CharacterCreator.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            CombatForm CombatForm = new CombatForm();
            CombatForm.Show();
        }
    }
}
