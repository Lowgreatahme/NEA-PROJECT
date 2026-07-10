using GameCORE.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCORE.Player_Classes
{
    public class Shade : AshBorn 
    {
        public Shade() 
        {
            Vigor = 65;
            CurrentVigor = 65;
            Strength = 6;
            Endurance = 6;
            Mind = 18;
            Speed = 20;
            SpecialAbility = "Veil Walk";
            GetDescription = "A wraith-like assassin who slips between realities, striking from the darkness before vanishing without a trace.";
        }

        public bool IsAlive => CurrentVigor > 0;
    }
}