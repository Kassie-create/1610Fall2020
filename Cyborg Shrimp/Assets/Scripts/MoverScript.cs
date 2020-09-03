using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoverScript : MonoBehaviour
{   
    public float speed = 3f;
    public string talkingPoint = "Hello World.";
    
    void Start()
    {
        Debug.Log("Hello World!");
    }
    void Update()
    {
        var x = speed * Input.GetAxis("Horizontal") * Time.deltaTime;
        var y = speed * Input.GetAxis("Vertical") * Time.deltaTime;
        var z = 0;
        transform.Translate(x,y,z);
    }
    public void Up()
    {
        transform.Translate(0, speed, 0);
    }
    
    public void Down()
    {
        transform.Translate(0, -speed, 0);
    }
}