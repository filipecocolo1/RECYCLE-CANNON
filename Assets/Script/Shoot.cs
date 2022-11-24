using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public int speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -speed);    

    }
    // Update is called once per frame
    void Update()
    {
    
    }
    //private void OnBecameInvisible()
    //{
    //    //Destroy(gameObject);
    //}

}
