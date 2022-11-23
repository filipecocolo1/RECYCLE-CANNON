using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public EnemyNav Enemy;  //Aqui onde vai armazenar o prefab
    public GameObject targetpoint;

    public float TempSpawn;//Tempo de spawn do Inimigo 
    [SerializeField] private float CountTemp; //Contador de Tempo para spawn 







    // Start is called before the first frame update
    void Start()
    {
        CountTemp = 0;

    }

    // Update is called once per frame
    void Update()
    {
        CountTemp += Time.deltaTime;
        if (CountTemp >= TempSpawn)
        {

            CountTemp = 0;
            EnemyNav e  = Instantiate(Enemy, this.transform.position, this.transform.rotation);
            e.Init(targetpoint); 
        }
    }
}

