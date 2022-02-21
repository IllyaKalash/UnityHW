﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public Vector2 speed = new Vector2(50, 50);
    private Vector2 movement;
    public Vector2 jumpHeight;
    void Update()
    {
        float inputX = Input.GetAxis("Space");
        float inputY = Input.GetAxis("Vertical");

        movement = new Vector2
            (speed.x * inputX,
             speed.y * inputY);
    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = movement;
    }
}