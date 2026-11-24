using GameCORE;
using GameCORE.Armament;
using GameCORE.Characters;
using GameCORE.Combat;
using GameCORE.Enumerations;
using GameDATA;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace NEA_PROJECT
{
    public partial class CombatForm : Form
    {
        string log = "";
        int TurnNum = 1;

        int CurrentWave = 1;
        

        public List<Enemy> Enemies = new List<Enemy>(); //List of enemies loaded from the JSON file
        public Enemy Enemy1;

        public void ActiveTurn(Move SelectedMove)
        {
            
            log = "Battle Log:\n" + Enemy1.Name + " HP: " + Enemy1.CurrentVigor + "\n" + Player.Name + " HP: " + Player.CurrentVigor + "\n";
            Combat_Engine combat_Engine = new Combat_Engine();
            BattleLog.Text = log;
            if (Player.CurrentMana < SelectedMove.ManaCost)
            {

                BattleLog.Text = "Not Enough Mana!";
                EnemyHP_Label_Change();
                return;
            }
            else
            {


                combat_Engine.TurnOrder(Enemy1, Player, SelectedMove);
                EnemyHP_Label_Change();
                BattleLog.Text += Enemy1.Name + "dealt " + Enemy1.LastDamageDealt + " damage to " + Player.Name + "\n" + Player.Name + " dealt " + Player.LastDamageDealt + " damage to " + Enemy1.Name;
                if (Enemy1.CurrentVigor <= 0)
                {

                    BattleLog.Text = "Victory!";
                    return;
                }
                else if (Player.CurrentVigor <= 0)
                {

                    BattleLog.Text = "LOST!";
                    return;
                }

                else
                {

                    TurnNum++;
                    BattleLog.Text += "\n \n" + log;
                }



            }


        }
        public CombatForm()
        {

            
            InitializeComponent();
            Enemies = JsonLoader.LoadEnemies("JSON Files\\EnemyData.json");



            if (Enemies != null && Enemies.Count > 0)
            {

                
                WavesManager wavesManager = new WavesManager(Player, Enemies, CurrentWave);
                Enemy1 = wavesManager.SelectEnemyForWave();
                log = "Turn 1: " + Enemy1.Name + " HP: " + Enemy1.CurrentVigor + "\n" + Player.Name + " HP: " + Player.CurrentVigor;
                BattleLog.Text = log;

            }
            else
            {
                BattleLog.Text = "No enemies loaded";
            }
        }
        public AshBorn Player = PlayerCreator.Player; //Carries over the saved character from CharacterCreator
        public JSONLoader JsonLoader = new JSONLoader(); //Creates a new instance of the JSONLoader class to load the JSON data




        private void Combat_Button_Click(object sender, EventArgs e)
        {


            DisableButtons(sender, e);
            Button Move1 = new Button();
            Button Move2 = new Button();
            Button Move3 = new Button();
            Button Move4 = new Button();
            int CurrentX = Move1.Location.X;
            int CurrentY = Move1.Location.Y;
            int MovesMade = 0;

            if (Player.Moves[0].MoveType == MoveType.Physical)
            {

                Move1.Size = new Size(120, 40);
                Move1.Text = Player.Moves[0].Name;
                Display_Panel.Controls.Add(Move1);

                MovesMade++;
            }
            if (Player.Moves[1].MoveType == MoveType.Physical)
            {

                Move2.Size = new Size(120, 40);
                Move2.Text = Player.Moves[1].Name;
                Display_Panel.Controls.Add(Move2);

                if (MovesMade == 1)
                {
                    Move2.Location = new Point(CurrentX, CurrentY + 40);
                }
                MovesMade++;
            }
            if (Player.Moves[2].MoveType == MoveType.Physical)
            {

                Move3.Size = new Size(120, 40);
                Move3.Text = Player.Moves[2].Name;
                Display_Panel.Controls.Add(Move3);

                if (MovesMade == 2)
                {
                    Move3.Location = new Point(CurrentX, CurrentY + 80);
                }

                else if (MovesMade == 1)
                {
                    Move3.Location = new Point(CurrentX, CurrentY + 40);
                }
                MovesMade++;
            }
            if (Player.Moves[3].MoveType == MoveType.Physical)
            {

                Move4.Size = new Size(120, 40);
                Move4.Text = Player.Moves[3].Name;
                Display_Panel.Controls.Add(Move4);
                if (MovesMade == 3)
                {
                    Move4.Location = new Point(CurrentX, CurrentY + 120);
                }
                else if (MovesMade == 2)
                {
                    Move4.Location = new Point(CurrentX, CurrentY + 80);
                }
                else if (MovesMade == 1)
                {
                    Move4.Location = new Point(CurrentX, CurrentY + 40);
                }
                MovesMade++;

            }



            WavesManager wavesManager = new WavesManager(Player, Enemies, CurrentWave);


            Move1.Click += (s, args) =>
        {
            ActiveTurn(Player.Moves[0]);
            Display_Panel.Controls.Clear();
            EnableMainButtons(sender, e);
            wavesManager.IncrementTurnsSurvived();
            wavesManager.IncrementWave();
        };
            Move2.Click += (s, args) =>
            {
                ActiveTurn(Player.Moves[1]);
                Display_Panel.Controls.Clear();
                EnableMainButtons(sender, e);
            };
            Move3.Click += (s, args) =>
            {
                ActiveTurn(Player.Moves[2]);
                Display_Panel.Controls.Clear();
                EnableMainButtons(sender, e);
            };
            Move4.Click += (s, args) =>
            {
                ActiveTurn(Player.Moves[3]);
                Display_Panel.Controls.Clear();
                EnableMainButtons(sender, e);
            };

        }







        private void Display_Panel_Paint(object sender, PaintEventArgs e) { }

        private void Magic_Button_Click(object sender, EventArgs e)
        {
            DisableButtons(sender, e);
            Button Move1 = new Button();
            Button Move2 = new Button();
            Button Move3 = new Button();
            Button Move4 = new Button();
            int CurrentX = Move1.Location.X;
            int CurrentY = Move1.Location.Y;
            int MovesMade = 0;

            if (Player.Moves[0].MoveType == MoveType.OffensiveMagic || Player.Moves[0].MoveType == MoveType.SupportiveMagic)
            {

                Move1.Size = new Size(120, 40);
                Move1.Text = Player.Moves[0].Name;
                Display_Panel.Controls.Add(Move1);

                MovesMade++;
            }
            if (Player.Moves[1].MoveType == MoveType.OffensiveMagic || Player.Moves[1].MoveType == MoveType.SupportiveMagic)
            {

                Move2.Size = new Size(120, 40);
                Move2.Text = Player.Moves[1].Name;
                Display_Panel.Controls.Add(Move2);

                if (MovesMade == 1)
                {
                    Move2.Location = new Point(CurrentX, CurrentY + 40);
                }
                MovesMade++;
            }
            if (Player.Moves[2].MoveType == MoveType.OffensiveMagic || Player.Moves[2].MoveType == MoveType.SupportiveMagic)
            {

                Move3.Size = new Size(120, 40);
                Move3.Text = Player.Moves[2].Name;
                Display_Panel.Controls.Add(Move3);

                if (MovesMade == 2)
                {
                    Move3.Location = new Point(CurrentX, CurrentY + 80);
                }

                else if (MovesMade == 1)
                {
                    Move3.Location = new Point(CurrentX, CurrentY + 40);
                }
                MovesMade++;
            }
            if (Player.Moves[3].MoveType == MoveType.OffensiveMagic || Player.Moves[3].MoveType == MoveType.SupportiveMagic)
            {

                Move4.Size = new Size(120, 40);
                Move4.Text = Player.Moves[3].Name;
                Display_Panel.Controls.Add(Move4);
                if (MovesMade == 3)
                {
                    Move4.Location = new Point(CurrentX, CurrentY + 120);
                }
                else if (MovesMade == 2)
                {
                    Move4.Location = new Point(CurrentX, CurrentY + 80);
                }
                else if (MovesMade == 1)
                {
                    Move4.Location = new Point(CurrentX, CurrentY + 40);
                }
                MovesMade++;

            }
            Move1.Click += (s, args) =>
            {
                ActiveTurn(Player.Moves[0]);
                Display_Panel.Controls.Clear();
                EnableMainButtons(sender, e);
            };
            Move2.Click += (s, args) =>
            {
                ActiveTurn(Player.Moves[1]);
                Display_Panel.Controls.Clear();
                EnableMainButtons(sender, e);
            };
            Move3.Click += (s, args) =>
            {
                ActiveTurn(Player.Moves[2]);
                Display_Panel.Controls.Clear();
                EnableMainButtons(sender, e);
            };
            Move4.Click += (s, args) =>
            {
                ActiveTurn(Player.Moves[3]);
                Display_Panel.Controls.Clear();
                EnableMainButtons(sender, e);
            };



        }

        private void CombatForm_Load(object sender, EventArgs e)
        {

        }

        private void DisableButtons(object sender, EventArgs e)
        {
            Combat_Button.Visible = false;
            Magic_Button.Visible = false;
            Items_Button.Visible = false;
            Act_Button.Visible = false;
            Combat_Button.Enabled = false;
            Magic_Button.Enabled = false;
            Items_Button.Enabled = false;
            Act_Button.Enabled = false;
        }
        private void EnableMainButtons(object sender, EventArgs e)
        {
            Combat_Button.Visible = true;
            Magic_Button.Visible = true;
            Items_Button.Visible = true;
            Act_Button.Visible = true;
            Combat_Button.Enabled = true;
            Magic_Button.Enabled = true;
            Items_Button.Enabled = true;
            Act_Button.Enabled = true;
        }
        private void EnemyHP_Label_Change()
        {
            
            int count = Enemy1.CurrentVigor / 10;
            int count2 = Enemy1.Vigor / 10;

            if (count > count2)
            {
                count = count2;
            }
            if (count2 < 1)
            {
                count2 = 0;
            }
            EnemyHP_Label.Text = "Enemy HP: [ " + ("#".PadLeft(count, '#'));
            EnemyHP_Label.Text += ("-".PadLeft(count2 - count, '-')) + " ]";


        }

        private void EnemyHP_Label_Click(object sender, EventArgs e)
        {

        }
    }
}
