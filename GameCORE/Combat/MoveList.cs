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
            moves.Add(new Move { Name = "Flail", BasePower = 20, Accuracy = 90, DamageType = DamageType.Physical, MoveType = MoveType.Physical });
            moves.Add(new Move { Name = "Slash", BasePower = 30, Accuracy = 85, DamageType = DamageType.Physical, MoveType = MoveType.Physical });
            moves.Add(new Magic { Name = "Fireball", BasePower = 40, Accuracy = 80, DamageType = DamageType.Fire, MoveType = MoveType.OffensiveMagic, ManaCost = 10 });
            moves.Add(new Magic { Name = "Ice Shard", BasePower = 35, Accuracy = 85, DamageType = DamageType.Frost, MoveType = MoveType.OffensiveMagic, ManaCost = 8 });

        }
    }
}
