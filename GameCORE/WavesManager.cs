using GameCORE.Characters;
using System;
using System.Collections.Generic;
using System.Text;
using GameCORE.Player_Classes;
using GameCORE.Enumerations;

namespace GameCORE
{
    public class WavesManager
    {
        public AshBorn Player { get; set; }
        public int CurrentWave { get; set; }
        public int EnemiesDefeated { get; set; }
        public int TurnsSurvived { get; set; }
        
        public Enemy CurrentEnemy { get; set; }
        public List<Enemy> Enemies { get; set; }

        public void ScaleEnemy(Enemy enemy, int scale)
        {
            enemy.CurrentVigor *= scale;
            enemy.Strength *= scale;
            enemy.Endurance *= scale;
            
        }
        public Enemy SelectEnemyForWave()
        {
            Random rnd = new Random();

            if (CurrentWave % 5 == 0)
            {
                int RandomIndex = rnd.Next(Enemies.Count - 2, Enemies.Count);
                CurrentEnemy = Enemies[RandomIndex];
                int scale = CurrentWave / 2;
                ScaleEnemy(CurrentEnemy, scale);
                return CurrentEnemy;
            }
            else
            {
                int RandomIndex = rnd.Next(0, Enemies.Count - 2);
                CurrentEnemy = Enemies[RandomIndex];
                int scale = CurrentWave / 2;
                ScaleEnemy(CurrentEnemy, scale);
                return CurrentEnemy;
            }
            
            
        }
        public void IncrementWave()
        {
            CurrentWave++;
        }
        public void IncrementEnemiesDefeated()
        {
            EnemiesDefeated++;
        }
        public void IncrementTurnsSurvived()
        {
            TurnsSurvived++;
        }
       

        public WavesManager(AshBorn player, List<Enemy> enemies, int CurrentWave)
        {
            Player = player;
            Enemies = enemies;
            this.CurrentWave = CurrentWave;
            EnemiesDefeated = 0;
            TurnsSurvived = 0;
            
        }
    }

}
