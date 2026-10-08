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
        public CombatForm()
        {
            InitializeComponent();
            Enemies = JsonLoader.LoadEnemies("JSON Files\\EnemyData.json");

            if (Enemies != null && Enemies.Count > 0)
            {
                MessageBox.Show("Enemies loaded: " + Enemies.Count);
                MessageBox.Show("Player moves: " + Player.moves.Count);
                Enemy1 = Enemies[0];
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
            Button Move1 = new Button();
            Button Move2 = new Button();

            if (Player.moves[0].MoveType == MoveType.Physical)
            {
                Display_Panel.Controls.Clear();
                
                Move1.Size = new Size(120, 40);
                Move1.Text = Player.moves[0].Name;
                Display_Panel.Controls.Add(Move1);
            }
            if (Player.moves[1].MoveType == MoveType.Physical)
            {
                Display_Panel.Controls.Clear();
               
                Move2.Size = new Size(120, 40);
                Move2.Text = Player.moves[1].Name;
                Display_Panel.Controls.Add(Move2);
            }
            

            


            

            Move1.Click += (s, args) =>
            {
                Combat_Engine CombatEngine = new Combat_Engine();
                CombatEngine.ExcecutePlayerTurn(Player, Enemy1, Player.moves[0]);
                BattleDisplay_Label.Text = Enemy1.Name + " HP: " + Enemy1.CurrentVigor;
            };
            Move2.Click += (s, args) =>
            {
                Combat_Engine CombatEngine = new Combat_Engine();
                CombatEngine.ExcecutePlayerTurn(Player, Enemy1, Player.moves[1]);
                BattleDisplay_Label.Text = Enemy1.Name + " HP: " + Enemy1.CurrentVigor;
            };

            Combat_Engine CombatEngine = new Combat_Engine();

         
        }

        

        private void Display_Panel_Paint(object sender, PaintEventArgs e) { }

        private void Magic_Button_Click(object sender, EventArgs e)
        {
            Display_Panel.Controls.Clear();
            Button button = new Button();
            button.Size = new Size(120, 40);
            button.Text = "Dynamic Button " + (50 / 45);
            button.Location = new Point(50, 50);
            Display_Panel.Controls.Add(button);
        }
    }
}
