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
            Random rnd = new Random();
            int RandomIndex = rnd.Next(0, CurrentEnemy.moves.Count);

            if (CurrentEnemy.CurrentVigor > CurrentEnemy.CurrentVigor/2)
            {
                return CurrentEnemy.moves[RandomIndex].Name;
            }
            else
            {
                int HalfnHalf = rnd.Next(0,2);
                if (HalfnHalf == 1)
                {
                    return "Heal";
                }
                else
                {
                    return CurrentEnemy.moves[RandomIndex].Name;
                }
            }
        }
    }
}
