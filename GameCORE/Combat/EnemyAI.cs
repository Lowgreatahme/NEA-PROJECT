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
            
            if (CurrentEnemy.moves == null || CurrentEnemy.moves.Count == 0)
                return string.Empty;

            Random rnd = new Random();
            int RandomIndex = rnd.Next(0, CurrentEnemy.moves.Count);

            
            if (CurrentEnemy.CurrentVigor > (CurrentEnemy.Vigor / 2))
            {
                return CurrentEnemy.moves[RandomIndex].Name;
            }
            else
            {
                int HalfnHalf = rnd.Next(0, 2);
                if (HalfnHalf == 1)
                {
                    
                    for (int x = 0; x < CurrentEnemy.moves.Count; x++)
                    {
                        if (CurrentEnemy.moves[x].MoveType == Enumerations.MoveType.SupportiveMagic)
                        {
                            return CurrentEnemy.moves[x].Name;
                        }
                    }

                   
                    return CurrentEnemy.moves[RandomIndex].Name;
                }
                else
                {
                    return CurrentEnemy.moves[RandomIndex].Name;
                }
            }
        }
    }
}
