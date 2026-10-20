using GameCORE.Armament;
using GameCORE.Characters;
using GameCORE.Combat;
using GameCORE.Enumerations;
using GameDATA;
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
        public List<Enemy> Enemies = new List<Enemy>(); //List of enemies loaded from the JSON file
        public Enemy Enemy1;

        public void ActiveTurn(Move SelectedMove)
        {
            string log = Enemy1.Name + " HP: " + Enemy1.CurrentVigor + "\n" + Player.Name + " HP: " + Player.CurrentVigor;
         Combat_Engine combat_Engine = new Combat_Engine();
            BattleDisplay_Label.Text = log;
            if (Player.CurrentMana < SelectedMove.ManaCost)
            {
                BattleDisplay_Label.Controls.Clear();
                BattleDisplay_Label.Text = "Not Enough Mana!";
                return;
            }
            else
            {
                
                
                    combat_Engine.TurnOrder(Enemy1, Player, SelectedMove);
                if (Enemy1.CurrentVigor <= 0)
                {
                    BattleDisplay_Label.Controls.Clear();
                    BattleDisplay_Label.Text = "Victory!";
                    return;
                }
                else if (Player.CurrentVigor <= 0)
                {
                    BattleDisplay_Label.Controls.Clear();
                    BattleDisplay_Label.Text = "LOST!";
                    return;
                }
                else
                {
                       BattleDisplay_Label.Controls.Clear();
                    BattleDisplay_Label.Text = log;
                }
                
                

            }


        }
        public CombatForm()
        {


            InitializeComponent();
            Enemies = JsonLoader.LoadEnemies("JSON Files\\EnemyData.json");

            

            if (Enemies != null && Enemies.Count > 0)
            {
                MessageBox.Show("Enemies loaded: " + Enemies.Count);
                MessageBox.Show("Player moves: " + Player.Moves.Count);
                Enemy1 = Enemies[7];
                BattleDisplay_Label.Text = Enemy1.Name;
            }
            else
            {
                BattleDisplay_Label.Text = "No enemies loaded";
            }
        }
        public AshBorn Player = PlayerCreator.Player; //Carries over the saved character from CharacterCreator
        public JSONLoader JsonLoader = new JSONLoader(); //Creates a new instance of the JSONLoader class to load the JSON data




        private void Combat_Button_Click(object sender, EventArgs e)
        {
            

            Display_Panel.Controls.Clear();
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






                Move1.Click += (s, args) =>
            {
                ActiveTurn(Player.Moves[0]);
            };
                Move2.Click += (s, args) =>
                {
                    ActiveTurn(Player.Moves[1]);
                };
                Move3.Click += (s, args) =>
                {
                    ActiveTurn(Player.Moves[2]);
                };
                Move4.Click += (s, args) =>
                {
                    ActiveTurn(Player.Moves[3]);
                };

            }
        

         
        

        

        private void Display_Panel_Paint(object sender, PaintEventArgs e) { }

        private void Magic_Button_Click(object sender, EventArgs e)
        {
            Display_Panel.Controls.Clear();
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
                else if(MovesMade == 2)
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
            };
            Move2.Click += (s, args) =>
            {
                ActiveTurn(Player.Moves[1]);
            };
            Move3.Click += (s, args) =>
            {
                ActiveTurn(Player.Moves[2]);

            };
            Move4.Click += (s, args) =>
            {
                ActiveTurn(Player.Moves[3]);
            };



        }
    }
}
