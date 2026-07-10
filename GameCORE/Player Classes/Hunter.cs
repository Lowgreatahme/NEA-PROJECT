using GameCORE.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCORE.Player_Classes
{
    public class Hunter : AshBorn  // Add inheritance
    {
        public Hunter()  // Add constructor
        {
            Vigor = 75;
            CurrentVigor = 75;
            Strength = 10;
            Endurance = 10;
            Mind = 8;
            Speed = 22;
            SpecialAbility = "Mark of the Prey";
            GetDescription = "A ruthless tracker and master of ranged combat who never loses sight of their quarry.";
        }

        public bool IsAlive => CurrentVigor > 0;
    }
}