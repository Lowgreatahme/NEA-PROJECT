using GameCORE.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCORE.Player_Classes
{
    public class Shade : AshBorn 
    {
        public Shade() 
        {
            Vigor = 65;
            CurrentVigor = 65;
            Strength = 6;
            Endurance = 6;
            Mind = 18;
            Speed = 20;
            StartingMana = 80;
            CurrentMana = 80;
            SpecialAbility = "Veil Walk";
            GetDescription = "A wraith-like assassin who slips between realities, striking from the darkness before vanishing without a trace.";

            TypeResistance = new Dictionary<DamageType, double>
{
    { DamageType.Physical, 0.9 },   // Resistant (shadowy, hard to hit)
    { DamageType.Holy, 1.3 },       // Very weak (dark class vulnerable to holy)
    { DamageType.Fire, 1.0 },       // Neutral
    { DamageType.Dark, 0.5 },       // Extremely resistant (shadow class)
    { DamageType.Magic, 0.8 },      // Resistant
    { DamageType.Frost, 1.0 },      // Neutral
    { DamageType.Poison, 0.8 },     // Resistant
    { DamageType.Lightning, 1.1 }   // Slightly weak
};

        }

        public bool IsAlive => CurrentVigor > 0;
    }
}