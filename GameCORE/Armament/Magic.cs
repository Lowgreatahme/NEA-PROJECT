using System;
using System.Collections.Generic;
using System.Text;
using GameCORE.Enumerations;    

namespace GameCORE.Armament
{
    public class Magic : Move
    {
        public Magic(string Name, MoveType MoveType, int BasePower, DamageType DamageType, int ManaCost)
            : base(Name, MoveType, BasePower, DamageType)
        {
            this.ManaCost = ManaCost;
        }

        public int ManaCost { get; set; }

    }
}
