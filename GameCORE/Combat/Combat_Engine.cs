using GameCORE.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCORE.Combat
{
    public class Combat_Engine
    {
        public void TurnOrder(Enemy enemy, AshBorn Player)
        {
          do {
            if (enemy.Speed > Player.Speed || enemy.Speed == Player.Speed)
            {
                ExcecuteTurn(enemy, Player);
                if (Player.CurrentVigor > 0)
                {
                    ExcecuteTurn(Player, enemy);
                }
               
            }
            if (enemy.Speed < Player.Speed)
            {
                ExcecuteTurn(Player, enemy);
                if (enemy.CurrentVigor > 0)
                {
                    ExcecuteTurn(enemy, Player);
                }
                
            }
            } while (enemy.CurrentVigor > 0 && Player.CurrentVigor > 0);
        }
        public void ExcecuteTurn(Character Attacker, Character Target)
        {
            if (Attacker is AshBorn)
            {
                AshBorn PlayerAttacker = (AshBorn)Attacker;
                Enemy EnemyTarget = (Enemy)Target;
                DamageCalculator DamageCalculator = new DamageCalculator();
                int damage = DamageCalculator.CalculateDamage(PlayerAttacker, EnemyTarget, PlayerAttacker.Weapon);
                EnemyTarget.CurrentVigor = EnemyTarget.CurrentVigor - damage;
            }
            else if (Attacker is Enemy)
            {
                Enemy EnemyAttacker = (Enemy)Attacker;
                AshBorn AshBornTarget = (AshBorn)Target;
                DamageCalculator DamageCalculator = new DamageCalculator();
                EnemyAI enemyAI = new EnemyAI();
                string move = enemyAI.SelectMove(EnemyAttacker, AshBornTarget);
                for (int x = 0; x < EnemyAttacker.moves.Count; x++)
                {
                    if (EnemyAttacker.moves[x].Name == move)
                    {
                       int damage = DamageCalculator.CalculateEnemyDamage(EnemyAttacker, AshBornTarget, EnemyAttacker.moves[x]);
                        AshBornTarget.CurrentVigor = AshBornTarget.CurrentVigor - damage;
                        if (AshBornTarget.CurrentVigor <= 0)
                        {
                            //Player is Dead
                        }
                        break;
                    }
                    
                }
                
                
            }
          
           
        }
    }
}
