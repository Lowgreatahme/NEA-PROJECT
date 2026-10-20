using GameCORE.Enumerations;
using GameCORE.Armament;
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
            Weapon = new Weapon { Name = "Rusty Flail", DamageType = DamageType.Physical, BaseDamage = 10, Description = "A heavy flail that delivers crushing blows.", StrengthMultiplier = 1.5, MindMultiplier = 0.8, Rarity = Rarity.Common };

            Moves.Add(new Move("Flail Strike", MoveType.Physical, 35, DamageType.Physical, 0, 0));
            Moves.Add(new Move("Divine Smite", MoveType.Physical, 50, DamageType.Holy, 0, 0));
            Moves.Add(new Magic("Holy Light", MoveType.OffensiveMagic, 30, DamageType.Holy, 20));
            Moves.Add(new Magic("Purifying Light", MoveType.SupportiveMagic, 40, DamageType.Holy, 30));
            

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