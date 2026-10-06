using GameCORE.Armament;
using GameCORE.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCORE.Characters
{
    public class Character
    {
        public string Name { get; set; } = "";
        public int Vigor { get; set; }
        public int CurrentVigor { get; set; }

        public int StartingMana { get; set; }
        public int CurrentMana { get; set; }
        public int Strength { get; set; }
        public int Endurance { get; set; }

        
        public Dictionary<DamageType, double> WeaponResistance { get; set; } = new Dictionary<DamageType, double>();
        public Dictionary<DamageType, double> TypeResistance { get; set; } = new Dictionary<DamageType, double>();

        //Dictionary in C# is a generic collection that stores key-value pairs. - GeeksForGeeks (A good way to store data based on a certain key!)
        public int Mind { get; set; }
        public int Speed { get; set; }
        public int DodgeChance { get; set; }
        public List<Move> moves { get; set; } = new List<Move>();

        public List<string> Inventory { get; set; } = new List<string>();
        public bool IsAlive;
       
    }
}
