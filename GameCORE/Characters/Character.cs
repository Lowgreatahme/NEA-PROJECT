using GameCORE.Combat;
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
        public int Strength { get; set; }
        public int Endurance { get; set; }

        //Dictionary in C# is a generic collection that stores key-value pairs. - GeeksForGeeks (A good way to store data based on a certain key!)
        public Dictionary<DamageType, double> WeaponResistance { get; set; }
        public Dictionary<DamageType, double> TypeResistance { get; set; }
        public int Mind { get; set; }
        public int Speed { get; set; }
        public int DodgeChance { get; set; }
        public List<Move> moves { get; set; } = new List<Move>();
        public List<string> Inventory { get; set; } = new List<string>();
        public bool IsAlive => CurrentVigor > 0;
       
    }
}
