using GameCORE.Armament;
using System;
using System.Collections.Generic;
using System.Text;
using GameCORE.Characters;

namespace GameCORE.Combat
{
    public class HealingCalculator
    {
        public static int CalculateHealing(AshBorn AshBorn, Magic Magic, Weapon Weapon)
        {
            int HealingAmount = (int)(AshBorn.Mind * 0.5 + Magic.BasePower) * Weapon.MindMultiplier;
            return HealingAmount;
        }
        public static int CalculateEnemyHealing(Enemy Enemy, Magic Magic)
        {
            int HealingAmount = (int)(Enemy.Mind * 0.5 + Magic.BasePower);
            return HealingAmount;
        }
    }
}
