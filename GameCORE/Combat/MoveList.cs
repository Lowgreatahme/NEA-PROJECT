using GameCORE.Armament;
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
            moves.Add(new Move("Flail", MoveType.Physical, 20, DamageType.Physical));
            moves.Add(new Move("Slash", MoveType.Physical, 30, DamageType.Physical));
            moves.Add(new Magic("Fireball", MoveType.OffensiveMagic, 40, DamageType.Fire, 10));
            moves.Add(new Magic("Ice Shard", MoveType.OffensiveMagic, 35, DamageType.Frost, 8));
        }
    }
}
