using GameCORE.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCORE.Player_Classes
{
    public class GraveKeeper : AshBorn  
    {
        public GraveKeeper()  
        {
            Vigor = 90;
            CurrentVigor = 90;
            Strength = 14;
            Endurance = 16;
            Mind = 12;
            Speed = 8;
            StartingMana = 100;
            CurrentMana = 100;

            TypeResistance = new Dictionary<DamageType, double>
{
    { DamageType.Physical, 0.8 },   // Resistant
    { DamageType.Holy, 1.2 },       // Weak (undead theme)
    { DamageType.Fire, 0.9 },       // Resistant
    { DamageType.Dark, 0.7 },       // Very resistant
    { DamageType.Magic, 1.0 },      // Neutral
    { DamageType.Frost, 1.1 },      // Slightly weak
    { DamageType.Poison, 0.85 },    // Resistant
    { DamageType.Lightning, 1.0 }   // Neutral
};

            SpecialAbility = "Soul Harvest";
            GetDescription = "A solemn sentinel of the dead who draws power from burial grounds and commands restless spirits.";
        }

        public bool IsAlive => CurrentVigor > 0;
    }
}