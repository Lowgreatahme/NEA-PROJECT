using GameCORE.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCORE.Armament
{
    public class Move
    {
        public Move(string Name, MoveType MoveType, int BasePower, DamageType DamageType)
        {
            this.Name = Name;
            this.MoveType = MoveType;
            this.BasePower = BasePower;
            
            this.DamageType = DamageType;
        }

        public string Name {  get; set; }
        public MoveType MoveType { get; set; }
        public int BasePower { get; set; }
        

        public DamageType DamageType { get; set; }

    }
}
