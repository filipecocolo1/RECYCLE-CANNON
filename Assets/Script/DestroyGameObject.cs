using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision outro)
    {
        if (outro.gameObject.tag == "PowerMetal")
        {
            Destroy(outro.gameObject);
        }

        if (outro.gameObject.tag == "PowerPlastic")
        {
            Destroy(outro.gameObject);
        }

        if (outro.gameObject.tag == "PowerOrganic")
        {
            Destroy(outro.gameObject);
        }
    }
}
