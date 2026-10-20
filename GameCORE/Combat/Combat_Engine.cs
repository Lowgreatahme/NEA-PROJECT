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
        public string ChosenMove;
        public void TurnOrder(Enemy enemy, AshBorn Player, Move move)
        {
          
            if (enemy.Speed > Player.Speed || enemy.Speed == Player.Speed)
            {
                ExcecuteTurn(enemy, Player);
                if (Player.CurrentVigor > 0)
                {
                    ExcecutePlayerTurn(Player, enemy, move);
                }
               
            }
            if (enemy.Speed < Player.Speed)
            {
                ExcecutePlayerTurn(Player, enemy, move);
                if (enemy.CurrentVigor > 0)
                {
                    ExcecuteTurn(enemy, Player);
                }
                
            }
            
        }
        public void ExcecutePlayerTurn(Character Attacker, Character Target, Move move)
        {
            AshBorn PlayerAttacker = (AshBorn)Attacker;
            Enemy EnemyTarget = (Enemy)Target;

            if (move.MoveType == MoveType.Physical)
            {
                
                int damage = DamageCalculator.CalculateDamage(PlayerAttacker, EnemyTarget, PlayerAttacker.Weapon, move);
                EnemyTarget.CurrentVigor = EnemyTarget.CurrentVigor - damage;
            }
            if (move.MoveType == MoveType.OffensiveMagic)
            {
               
                int Magicdamage = MagicDamageCalculator.CalculateMagicDamage(PlayerAttacker, EnemyTarget, move, PlayerAttacker.Weapon);
                EnemyTarget.CurrentVigor = EnemyTarget.CurrentVigor - Magicdamage;
                Attacker.CurrentMana -= move.ManaCost;
            }
            if (move.MoveType == MoveType.SupportiveMagic)
            {
                int Healing = HealingCalculator.CalculateHealing(PlayerAttacker, move, PlayerAttacker.Weapon);
                PlayerAttacker.CurrentVigor = PlayerAttacker.CurrentVigor + Healing;
                Attacker.CurrentMana -= move.ManaCost;

            }

            
        }
        public void ExcecuteTurn(Character Attacker, Character Target)
        {
           
             if (Attacker is Enemy)
            {
                Enemy EnemyAttacker = (Enemy)Attacker;
                AshBorn AshBornTarget = (AshBorn)Target;
                EnemyAI enemyAI = new EnemyAI();
                string Enemymove;
                bool loop = true;
                

do
{
    Enemymove = enemyAI.SelectMove(EnemyAttacker, AshBornTarget);

    loop = true;
    for (int i = 0; i < EnemyAttacker.Moves.Count; i++)
    {
        if (EnemyAttacker.Moves[i].Name == Enemymove)
        {
            loop = false;
            break;        
        }
    }

} while (loop);


                for (int x = 0; x < EnemyAttacker.Moves.Count; x++)
                {
                    if (EnemyAttacker.Moves[x].Name == Enemymove)
                    {
                        if (EnemyAttacker.Moves[x].MoveType == MoveType.OffensiveMagic) // ATTACKING MAGIC
                        {
                            ChosenMove = EnemyAttacker.Moves[x].Name;
                            int MagicDamage = MagicDamageCalculator.CalculateEnemyMagicDamage(EnemyAttacker, AshBornTarget, EnemyAttacker.Moves[x]);
                            AshBornTarget.CurrentVigor = AshBornTarget.CurrentVigor - MagicDamage;
                            EnemyAttacker.CurrentMana -= EnemyAttacker.Moves[x].ManaCost;

                            if (AshBornTarget.CurrentVigor <= 0)
                            {
                                //Player is Dead!
                                break;
                            }
                        }
                        else if (EnemyAttacker.Moves[x].MoveType == MoveType.SupportiveMagic) // HEALING MAGIC
                        {
                            ChosenMove = EnemyAttacker.Moves[x].Name;
                            int Healing = HealingCalculator.CalculateEnemyHealing(EnemyAttacker, EnemyAttacker.Moves[x]);
                            EnemyAttacker.CurrentVigor = EnemyAttacker.CurrentVigor + Healing;
                            EnemyAttacker.CurrentMana -= EnemyAttacker.Moves[x].ManaCost;
                        }
                        else if (EnemyAttacker.Moves[x].MoveType == MoveType.Physical)
                        {
                            ChosenMove = EnemyAttacker.Moves[x].Name;
                            int damage = DamageCalculator.CalculateEnemyDamage(EnemyAttacker, AshBornTarget, EnemyAttacker.Moves[x]); // PHYSICAL ATTACK
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
