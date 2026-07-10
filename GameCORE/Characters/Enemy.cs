using GameCORE.Combat;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCORE.Characters
{
    public class Enemy
    {
        
            public string Name { get; set; } = "";
            public int Vigor { get; set; }
            public int CurrentVigor { get; set; }
            public int Strength { get; set; }
            public int Endurance { get; set; }
            public int Mind { get; set; }
            public int Speed { get; set; }
            public int DodgeChance { get; set; }
            public List<Move> moves { get; set; } = new List<Move>(); 
        public bool IsAlive => CurrentVigor > 0;
            public bool IsBoss { get; set; }
        }
    }

