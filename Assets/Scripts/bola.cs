using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float speed = 300;
    private Vector2 velocity;

    void Start()
    {
        velocity.x = Random.Range(-1f, 1f);
        velocity.y = 1;
        rigidbody2D.AddForce(velocity*speed);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("DeadZone")) { 
        
        }
    }
}
