using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int vidas = 1;
    // Start is called before the first frame update
    void Start()
    {
        transform.tag = "Inimigo";
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider outro)
    {

        if (outro.gameObject.tag == "PowerMetal")

        {

            Destroy(outro.gameObject);
            vidas = vidas - 1;


            if (vidas == 0)

            {
                Destroy(this.gameObject);


            }
        }
        if (outro.gameObject.tag == "PowerPlastic")

        {

            Destroy(outro.gameObject);
            vidas = vidas - 1;


            if (vidas == 0)

            {
                Destroy(this.gameObject);


            }
        }
        if (outro.gameObject.tag == "PowerOrganic")

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