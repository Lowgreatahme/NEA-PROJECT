using GameCORE.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;
namespace GameCORE.Armament
{
    public class Weapon
    {
        public string Name { get; set; }
        public DamageType DamageType { get; set; }

        public int BaseDamage { get; set; } 
        public int StrengthMultiplier { get; set; }
        public int MindMultiplier { get; set; }
        public Rarity Rarity { get; set; }
        public string Description { get; set; }
    }
}