using GameCORE.Characters;
using GameCORE.Enumerations;
using GameCORE.Armament;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCORE.Player_Classes
{
    public class Arcanist : AshBorn
    {
        public Arcanist()
        {
            classname = "Arcanist";
            StartingMana = 100;
            CurrentMana = 100;
            Vigor = 70;
            CurrentVigor = 70;
            Strength = 6;
            Endurance = 8;
            Mind = 26;
            Speed = 10;
            DodgeChance = 10;
            SpecialAbility = "Eldritch Surge";
            GetDescription = "A scholar of forbidden knowledge who channels raw arcane energy to devastate foes from afar.";

            Weapon = new Weapon { Name = "Basic Arcane Staff", DamageType = DamageType.Magic, BaseDamage = 5, Description = "A staff with a crystal imbued with arcane energy, enhancing magical attacks.", StrengthMultiplier = 0.5, MindMultiplier = 1.5, Rarity = Rarity.Common };

            Moves.Add(new Move("Staff Strike", MoveType.Physical, 20, DamageType.Physical, 100, 0));
            Moves.Add(new Magic("Arcane Bolt", MoveType.OffensiveMagic, 30, DamageType.Magic, 10));
            Moves.Add(new Magic("Thunderclap", MoveType.OffensiveMagic, 50, DamageType.Lightning, 20));
            Moves.Add(new Magic("Flame Wave", MoveType.OffensiveMagic, 45, DamageType.Fire, 25));

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

        

        
        
    }
}