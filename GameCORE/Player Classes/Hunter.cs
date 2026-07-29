using GameCORE.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCORE.Player_Classes
{
    public class Hunter : AshBorn  
    {
        public Hunter()  
        {
            Vigor = 75;
            CurrentVigor = 75;
            Strength = 10;
            Endurance = 10;
            Mind = 8;
            Speed = 22;
            StartingMana = 50;
            CurrentMana = 50;
            SpecialAbility = "Mark of the Prey";
            GetDescription = "A ruthless tracker and master of ranged combat who never loses sight of their quarry.";

            TypeResistance = new Dictionary<DamageType, double>
{
    { DamageType.Physical, 0.9 },   // Resistant (light armor, agile)
    { DamageType.Holy, 1.0 },       // Neutral
    { DamageType.Fire, 1.0 },       // Neutral
    { DamageType.Dark, 1.0 },       // Neutral
    { DamageType.Magic, 1.0 },      // Neutral
    { DamageType.Frost, 1.0 },      // Neutral
    { DamageType.Poison, 0.7 },     // Very resistant (tracker, knows nature)
    { DamageType.Lightning, 0.8 }   // Resistant (agile, avoids)
};
        }

        public bool IsAlive => CurrentVigor > 0;
    }
}