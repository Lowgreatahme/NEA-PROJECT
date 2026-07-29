using GameCORE.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCORE.Combat
{
    public class Move
    {
        public string Name {  get; set; }
        public int BasePower { get; set; }
        public int Accuracy { get; set; }

        public DamageType DamageType { get; set; }

    }
}
