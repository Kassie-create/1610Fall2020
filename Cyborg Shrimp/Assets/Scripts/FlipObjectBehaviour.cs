using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipObjectBehaviour : MonoBehaviour
{
    private float rotateValue;
    private string inputString;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            rotateValue = 180;
        }
        
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            rotateValue = 0;
        }
        
        transform.rotation = Quaternion.Euler(0, rotateValue, 0);
    }
}
