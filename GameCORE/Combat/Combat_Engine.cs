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
            if (enemy.Speed > Player.Speed)
            {
                ExcecuteTurn(enemy, Player);
            }
            if (enemy.Speed < Player.Speed)
            {
                ExcecuteTurn(Player, enemy);
            }
        }
        public void ExcecuteTurn(Character Attacker, Character Target)
        {

        }
    }
}
