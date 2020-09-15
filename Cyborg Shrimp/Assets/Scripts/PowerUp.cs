using System;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public int value;

    private void OnTriggerEnter(Collider other)
    {
        value++;
        print(value);
    }
}