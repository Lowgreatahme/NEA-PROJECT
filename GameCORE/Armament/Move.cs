using GameCORE.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCORE.Armament
{
    public class Move
    {
        public string Name { get; set; } = "";
        public MoveType MoveType { get; set; }
        public DamageType DamageType { get; set; }
        public int BasePower { get; set; }
        public int Accuracy { get; set; }
        public int ManaCost { get; set; }
    

    public Move(string name, MoveType moveType, int basePower, DamageType damageType, int accuracy, int manaCost)
        {
            Name = name;
            MoveType = moveType;
            BasePower = basePower;
            DamageType = damageType;
            Accuracy = accuracy;
            ManaCost = manaCost;
        }
    }
}