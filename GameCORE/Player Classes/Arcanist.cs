using GameCORE.Characters;
using GameCORE.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCORE.Player_Classes
{
    public class Arcanist : AshBorn
    {
        public Arcanist()
        {
            StartingMana = 100;
            CurrentMana = 100;
            Vigor = 70;
            CurrentVigor = 70;
            Strength = 6;
            Endurance = 8;
            Mind = 26;
            Speed = 10;
            DodgeChance = 10;

            TypeResistance = new Dictionary<DamageType, double>
{
    { DamageType.Physical, 1.0 },   // Neutral
    { DamageType.Holy, 1.1 },       // Slightly weak
    { DamageType.Fire, 0.8 },       // Resistant
    { DamageType.Dark, 0.7 },       // Very resistant
    { DamageType.Magic, 0.6 },      // Very resistant (arcane scholar)
    { DamageType.Frost, 0.8 },      // Resistant
    { DamageType.Poison, 0.9 },     // Resistant
    { DamageType.Lightning, 1.0 }   // Neutral
};



        }

        

        public bool IsAlive => CurrentVigor > 0;
        public  string SpecialAbility = "Eldritch Surge";
        public string GetDescription = "A scholar of forbidden knowledge who channels raw arcane energy to devastate foes from afar.";
    }
}