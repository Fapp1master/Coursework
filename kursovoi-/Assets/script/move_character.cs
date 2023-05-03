using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_character : MonoBehaviour
{
    static public float speed = 3000f;

    private Vector2 movement;
    public Rigidbody2D rb;
    public Joystick joy;

    private float joyX, joyY;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        joyX = joy.Horizontal * speed;
        joyY = joy.Vertical * speed;

        movement = new Vector2(joyX *Time.deltaTime, joyY* Time.deltaTime);

        rb.AddForce(movement);
    }
}
