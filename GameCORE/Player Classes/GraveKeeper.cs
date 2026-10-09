using GameCORE.Armament;
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
            classname = "Grave Keeper";
            Vigor = 90;
            CurrentVigor = 90;
            Strength = 14;
            Endurance = 16;
            Mind = 12;
            Speed = 8;
            StartingMana = 100;
            CurrentMana = 100;
            SpecialAbility = "Soul Harvest";
            GetDescription = "A solemn sentinel of the dead who draws power from burial grounds and commands restless spirits.";
            Weapon = new Weapon { Name = "Shovel", DamageType = DamageType.Physical, BaseDamage = 5, Description = "A sturdy shovel used for digging graves.", StrengthMultiplier = 1.2, MindMultiplier = 1.0, Rarity = Rarity.Common };
            
            moves.Add(new Move("Shovel Strike", MoveType.Physical, 30, DamageType.Physical));
            moves.Add(new Move("Wraith Grip", MoveType.Physical, 40, DamageType.Dark));
            moves.Add(new Move("Crucify", MoveType.OffensiveMagic, 50, DamageType.Holy));
            moves.Add(new Move("Soul Harvest", MoveType.SupportiveMagic, 0, DamageType.Dark));


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

            
        }

        public bool IsAlive => CurrentVigor > 0;
    }
}