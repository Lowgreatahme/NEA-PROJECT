using GameCORE.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCORE.Player_Classes
{
    public class GraveKeeper : AshBorn  
    {
        public GraveKeeper()  
        {
            Vigor = 90;
            CurrentVigor = 90;
            Strength = 14;
            Endurance = 16;
            Mind = 12;
            Speed = 8;
            SpecialAbility = "Soul Harvest";
            GetDescription = "A solemn sentinel of the dead who draws power from burial grounds and commands restless spirits.";
        }

        public bool IsAlive => CurrentVigor > 0;
    }
}