using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D body;
    public float jumpPower;

    void Start()
    {
        gameObject.name = "Chiki Briki";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            body.velocity = Vector2.up * jumpPower;
        }
    }
}
