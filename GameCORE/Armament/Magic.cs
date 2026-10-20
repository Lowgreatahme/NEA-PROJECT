using System;
using System.Collections.Generic;
using System.Text;
using GameCORE.Enumerations;

namespace GameCORE.Armament
{
    public class Magic : Move
    {


        public int ManaCost { get; set; }

    
    public Magic(string name, MoveType moveType, int basePower, DamageType damageType, int manaCost)
    : base(name, moveType, basePower, damageType, manaCost, 0)
    {
        ManaCost = manaCost;
    }
    }
}
