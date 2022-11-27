using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MovimentJoystick : MonoBehaviour
{
    private float _Speed = 5, moveV, moveH;
    public FixedJoystick moveJoystick;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovementPlayer();

    }
    public void MovementPlayer()
    {

        moveH = moveJoystick.Horizontal;
        moveV = moveJoystick.Vertical;
        
        rb.velocity = new Vector3(moveH * _Speed, rb.velocity.y, moveV * _Speed);
       
        Vector3 dir = new Vector3(moveH, 0, moveV);
        
        if (dir != Vector3.zero)
        {
            transform.LookAt(transform.position + dir);
        }

    }
}
