using GameCORE.Armament;
using GameCORE.Characters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace GameCORE.Combat
{
    // Pokemon Red and Blue Damage Formula simplified: F = (((2 × Level / 5 + 2) × BasePower × Attack / Defense) / 50 + 2) × Modifier
    // Changed Formula to fit the project - Damage = ((BaseDamage + (AttackPower × ScalingFactor)) × TypeModifier) - (Defense × MitigationRate)
    public class DamageCalculator
    {
        private static readonly Random rng = new Random();
        public static int CalculateDamage(Character attacker, Character defender, Weapon weapon)
        {
            
            if (weapon.StrengthMultiplier > 0)
            {
                double RawDamage = 0;
                double Scaling = weapon.StrengthMultiplier;
                double BaseDamage = weapon.BaseDamage;
                double AttackerStrength = attacker.Strength;
                double DefenderEndurance = defender.Endurance;
                double Resistance = defender.WeaponResistance[weapon.DamageType]; //Use of a dictionary by looking up if the defender has resistance to the weapon's damage type and stores it into resistance.
                double Mitigation = rng.Next(3, 7) / 100.0; //Returns a number between 0.03 and 0.07 as a mitigation to apply RNG like in Pokemon. This is a random number between 3% and 7% to simulate variability in damage.
                RawDamage = ((BaseDamage + (AttackerStrength * Scaling)) * Resistance) - (DefenderEndurance * Mitigation);
                return (int)RawDamage;
            }
            if (weapon.MindMultiplier > 0)
            {
                double RawDamage = 0;
                double Scaling = weapon.MindMultiplier;
                double BaseDamage = weapon.BaseDamage;
                double AttackerMind = attacker.Mind;
                double DefenderEndurance = defender.Endurance;
                double Resistance = defender.WeaponResistance[weapon.DamageType]; //Use of a dictionary by looking up if the defender has resistance to the weapon's damage type and stores it into resistance.
                double Mitigation = rng.Next(3, 7) / 100.0; //Returns a number between 0.03 and 0.07 as a mitigation to apply RNG like in Pokemon. This is a random number between 3% and 7% to simulate variability in damage.
                RawDamage = ((BaseDamage + (AttackerMind * Scaling)) * Resistance) - (DefenderEndurance * Mitigation);
                return (int)RawDamage;
            }
            else
            {
                double RawDamage = 0;
                double BaseDamage = weapon.BaseDamage;
                double DefenderEndurance = defender.Endurance;
                double Resistance = defender.WeaponResistance[weapon.DamageType]; //Use of a dictionary by looking up if the defender has resistance to the weapon's damage type and stores it into resistance.
                double Mitigation = rng.Next(3, 7) / 100.0; //Returns a number between 0.03 and 0.07 as a mitigation to apply RNG like in Pokemon. This is a random number between 3% and 7% to simulate variability in damage.
                RawDamage = (BaseDamage * Resistance) - (DefenderEndurance * Mitigation);
                return (int)RawDamage;
            }
        }
        public static int CalculateEnemyDamage(Enemy attacker, AshBorn defender, Move move)
        {
            double RawDamage = 0;
            double BaseDamage = move.BasePower;
            double AttackerStrength = attacker.Strength;
            double DefenderEndurance = defender.Endurance;
            double Resistance = defender.TypeResistance[move.DamageType];
            double Mitigation = rng.Next(3, 7) / 100.0;
            RawDamage = ((BaseDamage + (AttackerStrength) * Resistance) - (DefenderEndurance * Mitigation));
            return (int)RawDamage;
        }
    }
}
