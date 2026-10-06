using GameCORE;
using GameCORE.Armament;
using GameCORE.Characters;

public class AshBorn : Character
{
    public string classname { get; set; }
    public string Gender { get; set; }
    public int StartingMana { get; set; }
    public string SpecialAbility { get; set; }
    public Weapon Weapon { get; set; }
    public Armour Armour { get; set; }
    public Talisman Talisman { get; set; }
    public string GetDescription { get; set; }  

     
    
}