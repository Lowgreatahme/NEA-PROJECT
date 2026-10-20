using GameCORE.Enumerations;
using GameCORE.Armament;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCORE.Player_Classes
{
    public class Shade : AshBorn 
    {
        public Shade() 
        {
            classname = "Shade";
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
            Weapon = new Weapon { Name = "Shadow Dagger", DamageType = DamageType.Physical, BaseDamage = 12, Description = "A dagger forged from the essence of shadows, allowing the wielder to strike unseen.", StrengthMultiplier = 1.0, MindMultiplier = 1.2, Rarity = Rarity.Rare };

            Moves.Add(new Move("Shadow Strike", MoveType.Physical, 30, DamageType.Physical, 90, 0));
            Moves.Add(new Move("Phantom Slash", MoveType.Physical, 50, DamageType.Dark, 80, 0));
            Moves.Add(new Magic("Dark Bolt", MoveType.OffensiveMagic, 40, DamageType.Dark, 15));
            Moves.Add(new Magic("Ethereal Veil", MoveType.DefensiveMagic, 0, DamageType.Dark, 20));

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