﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody PlayerRb;
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround;
    public BoolData gameOver;
    
    
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        gameOver.value = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& isOnGround)
        {
            PlayerRb.AddForce(Vector3.up * 8, ForceMode.Impulse);
            isOnGround = false;
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }else if (collision.other.CompareTag("Obstacle"))
        {
            gameOver.value = true;
            Debug.Log("Game Over");
        }
    }
}
