using GameCore;
using GameCORE.Armament;
using GameCORE.Characters;

public class AshBorn : Enemy
{
    public string SpecialAbility { get; set; }
    public Weapon StartingWeapon { get; set; }
    public Armour StartingArmour { get; set; }
    public Talisman StartingTalisman { get; set; }
    public string GetDescription { get; set; }  
}