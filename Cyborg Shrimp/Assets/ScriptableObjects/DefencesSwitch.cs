using UnityEngine;

[CreateAssetMenu]
public class DefencesSwitch : ScriptableObject
{
    public enum Defences
    {
        Shield,
        Potions,
        ExtraHealth,
        Buffs,
        SuperShield,
        Armor,
        SuperArmor
    }

    public Defences currentDefence;

    public void RunCurrentDefence()
    {
        switch (currentDefence)
        {
            case Defences.Shield:
                //Function
                break;
            case Defences.Potions:
                //Function
                break;
            case Defences.ExtraHealth:
                //Function
                break;
            case Defences.Buffs:
                //Function
                break;
            case Defences.SuperShield:
                //Function
                break;
            case Defences.Armor:
                //Function
                break;
            case Defences.SuperArmor:
                //function
                break;
        }
    }
}