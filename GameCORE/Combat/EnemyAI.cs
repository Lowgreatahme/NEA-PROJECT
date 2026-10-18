using GameCORE.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCORE.Combat
{
    public class EnemyAI
    {
        public string SelectMove(Enemy CurrentEnemy, AshBorn Player)
        {
            
            if (CurrentEnemy.Moves == null || CurrentEnemy.Moves.Count == 0)
                return string.Empty;

            Random rnd = new Random();
            int RandomIndex = rnd.Next(0, CurrentEnemy.Moves.Count);

            
            if (CurrentEnemy.CurrentVigor > (CurrentEnemy.Vigor / 2))
            {
                return CurrentEnemy.Moves[RandomIndex].Name;
            }
            else
            {
                int HalfnHalf = rnd.Next(0, 2);
                if (HalfnHalf == 1)
                {
                    
                    for (int x = 0; x < CurrentEnemy.Moves.Count; x++)
                    {
                        if (CurrentEnemy.Moves[x].MoveType == Enumerations.MoveType.SupportiveMagic)
                        {
                            return CurrentEnemy.Moves[x].Name;
                        }
                    }

                   
                    return CurrentEnemy.Moves[RandomIndex].Name;
                }
                else
                {
                    return CurrentEnemy.Moves[RandomIndex].Name;
                }
            }
        }
    }
}
