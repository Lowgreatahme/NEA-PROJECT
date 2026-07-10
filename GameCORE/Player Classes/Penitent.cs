using GameCORE.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCORE.Player_Classes
{
    public class Penitent : AshBorn 
    {
        public Penitent() 
        {
            Vigor = 100;
            CurrentVigor = 100;
            Strength = 16;
            Endurance = 20;
            Mind = 10;
            Speed = 4;
            SpecialAbility = "Atonement";
            GetDescription = "A flagellant warrior who endures suffering to fuel their divine wrath and protect the faithful.";
        }

        public bool IsAlive => CurrentVigor > 0;
    }
}