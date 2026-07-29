using GameCore;
using GameCORE.Armament;
using GameCORE.Characters;

public class AshBorn : Character
{
    public string Gender { get; set; }
    public int StartingMana { get; set; }
    public int CurrentMana { get; set; }
    public string SpecialAbility { get; set; }
    public Weapon StartingWeapon { get; set; }
    public Armour StartingArmour { get; set; }
    public Talisman StartingTalisman { get; set; }
    public string GetDescription { get; set; }  
    
}