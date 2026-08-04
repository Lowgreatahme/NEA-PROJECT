using GameCORE.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCORE.Player_Classes
{
    public class Penitent : AshBorn 
    {
        public Penitent() 
        {
            classname = "Penitent";
            Vigor = 100;
            CurrentVigor = 100;
            Strength = 16;
            Endurance = 20;
            Mind = 10;
            Speed = 4;
            StartingMana = 50;
            CurrentMana = 50;
            SpecialAbility = "Atonement";
            GetDescription = "A flagellant warrior who endures suffering to fuel their divine wrath and protect the faithful.";

            TypeResistance = new Dictionary<DamageType, double>
{
    { DamageType.Physical, 0.7 },   // Very resistant (heavy armor)
    { DamageType.Holy, 0.5 },       // Extremely resistant (divine class)
    { DamageType.Fire, 0.8 },       // Resistant
    { DamageType.Dark, 1.2 },       // Weak (holy class vulnerable to dark)
    { DamageType.Magic, 1.0 },      // Neutral
    { DamageType.Frost, 0.9 },      // Resistant
    { DamageType.Poison, 0.8 },     // Resistant
    { DamageType.Lightning, 0.9 }   // Resistant
};
        }

        public bool IsAlive => CurrentVigor > 0;
    }
}