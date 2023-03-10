using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody2D rigidBody2D;
    private float inputvalue;
    public float movespeed = 25;
    private Vector2 direction;

    void Update()
    {
        inputvalue = Input.GetAxisRaw("Horizontal");
        if (inputvalue ==1 )
        {
            direction = Vector2.right;
        }
        else 
        if(inputvalue==-1){
            direction = Vector2.left;
        }
        else
        {
            direction = Vector2.zero;
        }

        rigidBody2D.AddForce (direction * movespeed *Time.deltaTime * 100);
    }
}
