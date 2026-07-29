using GameCORE.Player_Classes;
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



        private void CharacterCreator_Load(object sender, EventArgs e)
        {

        }

        private void GraveKeeper_Select_Click(object sender, EventArgs e)
        {
            Display_Label.Text = "A solemn sentinel of the dead who draws power from burial grounds and commands restless spirits. \r\nVigor = 90;\r\nStrength = 14;\r\nEndurance = 16;\r\nMind = 12;\r\nSpeed = 8;\r\nStartingMana = 100;\r\nMana = 100;";
            AshBorn player = new AshBorn();
            player = new GraveKeeper();


        }
        private void Penitent_Select_Click(object sender, EventArgs e)
        {
            Display_Label.Text = "A flagellant warrior who endures suffering to fuel their divine wrath and protect the faithful. \r\nVigor = 85;\r\nStrength = 12;\r\nEndurance = 18;\r\nMind = 10;\r\nSpeed = 10;\r\nStartingMana = 60;\r\nMana = 60;";
            AshBorn player = new AshBorn();
            player = new Penitent();
        }

        private void Arcanist_Select_Click(object sender, EventArgs e)
        {
            Display_Label.Text = "A scholar of forbidden knowledge who channels raw arcane energy to devastate foes from afar. \r\nVigor = 75;\r\nStrength = 10;\r\nEndurance = 12;\r\nMind = 16;\r\nSpeed = 14;\r\nStartingMana = 140;\r\nMana = 140;";
            AshBorn player = new AshBorn();
            player = new Arcanist();
        }

        private void Hunter_Select_Click(object sender, EventArgs e)
        {
            Display_Label.Text = "A ruthless tracker and master of ranged combat who never loses sight of their quarry. \r\nVigor = 80;\r\nStrength = 16;\r\nEndurance = 14;\r\nMind = 10;\r\nSpeed = 12;\r\nStartingMana = 80;\r\nMana = 80;";
            AshBorn player = new AshBorn();
            player = new Hunter();
        }

        private void Shade_Select_Click(object sender, EventArgs e)
        {
            Display_Label.Text = "A shadowy figure who moves between the worlds of the living and the dead, wielding the power of twilight. \r\nVigor = 70;\r\nStrength = 12;\r\nEndurance = 10;\r\nMind = 14;\r\nSpeed = 16;\r\nStartingMana = 120;\r\nMana = 120;";
            AshBorn player = new AshBorn();
            player = new Shade();
        }

        private void Display_Label_Click(object sender, EventArgs e)
        {

        }

        private void Confirm_Select_Click(object sender, EventArgs e)
        {
           
        }

        private void Confirm_Select_Click_1(object sender, EventArgs e)
        {
            PlayerCreator playerCreator = new PlayerCreator();
            playerCreator.Show();
            this.Close();
        }
    }
}



// This is so fucking muchhhhh - i cant do thissss anymoreeee
// YESSSSS FINALYYY
// OMD you have no idea how good that feels...
//Nvm this is stressful as fuck again..