﻿using UnityEngine;

public class Obstacle : MonoBehaviour
{
    Rigidbody2D rb;
    public float MoveSpeed;
    public float ObstaclePosition = 15f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //if obstacle's position x is < -15f it will be destroyed
        if(transform.position.x < -ObstaclePosition)
        {
            Destroy(gameObject);
        }
        //if obstacle's position x is < -15f it will be destroyed
        if (transform.position.x > ObstaclePosition)
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = Vector2.left * MoveSpeed;
    }
}
