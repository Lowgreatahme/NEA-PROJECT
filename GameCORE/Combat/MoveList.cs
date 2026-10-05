using GameCORE.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace GameCORE.Combat
{
    public class MoveList
    {
        public List<Move> moves { get; set; } = new List<Move>();

        public MoveList()
        {
            moves.Add(new Move { Name = "Flail", BasePower = 20, Accuracy = 90, DamageType = DamageType.Physical });
        }
    }
}
