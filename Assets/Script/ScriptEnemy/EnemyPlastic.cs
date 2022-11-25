using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlastic : MonoBehaviour
{
    [SerializeField] private int vidas = 1;

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

        if (outro.gameObject.tag == "PowerPlastic")
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