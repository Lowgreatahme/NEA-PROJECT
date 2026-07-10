using GameCORE.Characters;
using GameCORE.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCORE.Player_Classes
{
    public class Arcanist : AshBorn
    {
        public Arcanist()
        {
            Vigor = 70;
            CurrentVigor = 70;
            Strength = 6;
            Endurance = 8;
            Mind = 26;
            Speed = 10;
            DodgeChance = 10;

        }

        public bool IsAlive => CurrentVigor > 0;
        public  string SpecialAbility = "Eldritch Surge";
        public string GetDescription = "A scholar of forbidden knowledge who channels raw arcane energy to devastate foes from afar.";
    }
}