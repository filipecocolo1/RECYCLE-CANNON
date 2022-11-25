using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    public GameObject Plastic;
    public GameObject Metal;
    public GameObject Organic;
    public float _Speed;
    Rigidbody rb;
    public int vidas = 3;
    public Transform Guntip;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
 
    private void FixedUpdate()
    {
        Vector3 Position = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        rb.velocity = Position * _Speed;

    }
    public void PowerPlastic()
    {
        Instantiate(Plastic, Guntip.position, transform.rotation);
    }
    public void PowerMetal()
    {
        Instantiate(Metal, Guntip.position, transform.rotation);
    }

    public void PowerOrganic()
    {
        Instantiate(Organic, Guntip.position, transform.rotation);
    }
    
    
    void OnCollisionEnter(Collision outro)
    {
        if (outro.gameObject.tag == "Inimigo")
        {
            Destroy(outro.gameObject);
            vidas = vidas - 1;
            if (vidas == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }


}




