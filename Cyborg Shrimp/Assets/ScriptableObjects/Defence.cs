using UnityEngine;

[CreateAssetMenu]
public class Defence : Collectible
{
    public float powerLevel = 0.5f;

    public override void Use()
    {
        Debug.Log(this.name);
    }
}