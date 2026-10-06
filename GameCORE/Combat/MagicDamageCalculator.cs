using GameCORE.Armament;
using GameCORE.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCORE.Combat
{
    public class MagicDamageCalculator
    {
        private static readonly Random rng = new Random();
        public static int CalculateMagicDamage(Character attacker, Character defender, Magic Magic, Weapon weapon)
        {
            double RawDamage = 0;
            double Resistance = defender.TypeResistance[Enumerations.DamageType.Magic];
            double Scaling = weapon.MindMultiplier;
            double BaseDamage = Magic.BasePower;
            double AttackerMind = attacker.Mind;
            double DefenderEndurance = defender.Endurance;
            double Mitigation = rng.Next(3, 7) / 100.0; //Returns a number between 0.03 and 0.07 as a mitigation to apply RNG like in Pokemon. This is a random number between 3% and 7% to simulate variability in damage.
            RawDamage = RawDamage + ((BaseDamage + (AttackerMind * Scaling)) * Resistance) - (DefenderEndurance * Mitigation);
            attacker.CurrentMana = attacker.CurrentMana - Magic.ManaCost;
            return (int)RawDamage;
            

            
        }
        public static int CalculateEnemyMagicDamage(Enemy attacker, AshBorn defender, Move Magic)
        {
            double RawDamage = 0;
            double BaseDamage = Magic.BasePower;
            double AttackerMind = attacker.Mind;
            double DefenderEndurance = defender.Endurance;
            double Resistance = defender.TypeResistance[Magic.DamageType];
            double Mitigation = rng.Next(3, 7) / 100.0;
            RawDamage = ((BaseDamage + (AttackerMind) * Resistance) - (DefenderEndurance * Mitigation));
            
            return (int)RawDamage;
           
        }
    }
}
