using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeBase : MonoBehaviour
{
    public int vidas =10;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider outro)
    {

        if (outro.gameObject.tag == "Inimigo")

        {

            Destroy(outro.gameObject);
            vidas = vidas - 1;


            if (vidas == 0) 

            {
                Destroy(this.gameObject);

                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
