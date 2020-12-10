using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CoinCollection : ScriptableObject
{
    public List<Transform> collectedTransforms;

    public void Collect(Transform obj)
    {
        collectedTransforms.Add(obj);
    }

    public void PrintCollection()
    {
        foreach (var obj in collectedTransforms)
        {
            Debug.Log(obj);   
        }
    }
}