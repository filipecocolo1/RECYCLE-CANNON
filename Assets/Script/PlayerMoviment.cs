using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    public GameObject shoot;
    public float _Speed;
    Rigidbody rb;
    public Transform Guntip;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        Vector3 Position = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        rb.velocity = Position * _Speed;

    }
    private void Atirar()
    {

        Instantiate(shoot, Guntip.position, transform.rotation);

    }
}




