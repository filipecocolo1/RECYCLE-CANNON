using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MovimentJoystick : MonoBehaviour
{
    private float _Speed , moveV, moveH;
    public FixedJoystick moveJoystick;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovementPlayer();
      
    }
    public void MovementPlayer()
    {

        moveV = moveJoystick.Horizontal;
        moveH = moveJoystick.Vertical;

        Vector3 Position = new Vector3(moveH, 0, moveV);
        rb.velocity = new Vector3(moveH * _Speed, rb.velocity.y, moveV * _Speed);
        if (Position != Vector3.zero)
        {


            transform.LookAt(transform.position + Position);


        }

    }
}
