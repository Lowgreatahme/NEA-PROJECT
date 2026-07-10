using GameCORE.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;
namespace GameCore
{ 
    
        public class Armour
        {
            public string Name { get; set; }
            public int VigorMultiplier { get; set; }
            public int EnduranceMultiplier { get; set; }
            public int DodgeMultiplier { get; set; }
            public int SpeedMultiplier { get; set; }
            public Rarity Rarity { get; set; }
            public string Description { get; set; }
        }
    
}

