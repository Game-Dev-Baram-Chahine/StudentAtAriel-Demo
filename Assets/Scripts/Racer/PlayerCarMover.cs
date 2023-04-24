using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCarMover : MonoBehaviour
{
    public float speed = 50.0f; // The speed at which the object moves
    public KeyCode upKey = KeyCode.UpArrow; // The key to move up
    public KeyCode downKey = KeyCode.DownArrow; // The key to move down
    public float topLimit;
    public float botLimit;

    private Rigidbody rb; // The Rigidbody component of the object

    void Start()
    {
        // Get the Rigidbody2D component of the object
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Check if the up key is pressed
        if (Input.GetKey(upKey) && rb.position.y<topLimit)
        {
            // Move the object up
            rb.velocity = new Vector2(0.0f, speed);
        }
        // Check if the down key is pressed
        else if (Input.GetKey(downKey) && rb.position.y > botLimit)
        {
            // Move the object down
            rb.velocity = new Vector2(0.0f, -speed);
        }
        else
        {
            // Stop moving the object if neither key is pressed
            rb.velocity = Vector2.zero;
        }
    }
}
