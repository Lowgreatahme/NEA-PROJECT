using GameCORE.Armament;
using GameCORE.Characters;
using GameCORE.Enumerations;
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
        public void ExcecutePlayerTurn(Character Attacker, Character Target, Move move)
        {
            AshBorn PlayerAttacker = (AshBorn)Attacker;
            Enemy EnemyTarget = (Enemy)Target;
            DamageCalculator DamageCalculator = new DamageCalculator();
            int damage = DamageCalculator.CalculateDamage(PlayerAttacker, EnemyTarget, PlayerAttacker.Weapon, move);
            EnemyTarget.CurrentVigor = EnemyTarget.CurrentVigor - damage;
        }
        public void ExcecuteTurn(Character Attacker, Character Target)
        {
           
             if (Attacker is Enemy)
            {
                Enemy EnemyAttacker = (Enemy)Attacker;
                AshBorn AshBornTarget = (AshBorn)Target;
                DamageCalculator DamageCalculator = new DamageCalculator();
                MagicDamageCalculator MagicDamageCalculator = new MagicDamageCalculator();
                EnemyAI enemyAI = new EnemyAI();
                string Enemymove = enemyAI.SelectMove(EnemyAttacker, AshBornTarget);
                
                for (int x = 0; x < EnemyAttacker.moves.Count; x++)
                {
                    if (EnemyAttacker.moves[x].Name == Enemymove)
                    {
                        if (EnemyAttacker.moves[x].MoveType == MoveType.OffensiveMagic) // ATTACKING MAGIC
                        {
                            int MagicDamage = MagicDamageCalculator.CalculateEnemyMagicDamage(EnemyAttacker, AshBornTarget, EnemyAttacker.moves[x]);
                            AshBornTarget.CurrentVigor = AshBornTarget.CurrentVigor - MagicDamage;
                            Magic MagicMove = (Magic)EnemyAttacker.moves[x]; // Converts the Move to a Magic type so I can access the ManaCost
                            EnemyAttacker.CurrentMana -= MagicMove.ManaCost;
                        
                            if (AshBornTarget.CurrentVigor <= 0)
                            {
                                //Player is Dead!
                                break;
                            }
                        }
                        else if (EnemyAttacker.moves[x].MoveType == MoveType.SupportiveMagic) // HEALING MAGIC
                        {
                            int Healing = HealingCalculator.CalculateEnemyHealing(EnemyAttacker, EnemyAttacker.moves[x]);
                            EnemyAttacker.CurrentVigor = EnemyAttacker.CurrentVigor + Healing;
                            Magic HealingMove = (Magic)EnemyAttacker.moves[x];
                            EnemyAttacker.CurrentMana -= HealingMove.ManaCost;
                        }
                        else
                        {
                            int damage = DamageCalculator.CalculateEnemyDamage(EnemyAttacker, AshBornTarget, EnemyAttacker.moves[x]); // PHYSICAL ATTACK
                            AshBornTarget.CurrentVigor = AshBornTarget.CurrentVigor - damage;
                            if (AshBornTarget.CurrentVigor <= 0)
                            {
                                //Player is Dead!
                                break;
                            }
                            
                        }
                    }
                    
                }
                
                
            }
          
           
        }
    }
}
