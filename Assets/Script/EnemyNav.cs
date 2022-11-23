using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class EnemyNav : MonoBehaviour
{
    private NavMeshAgent _navMesh;
    private GameObject point;
    private GameObject player;



    //private GameObject Atualpoint;

    // Start is called before the first frame update
    void Start()
    {


        player = GameObject.FindWithTag("Player");
        _navMesh = GetComponent<NavMeshAgent>();

    }
    // Update is called once per frame
    void Update()
    {

    }

    public void patrol()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(point.transform.position);

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _navMesh.destination = player.transform.position;


        }


    }
    public void OnTriggerExit(Collider other)
    {
        patrol();
    }

    public void nTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            _navMesh.destination = player.transform.position;


        }
    }
    public void Init(GameObject target)
    {
        point = target;
        patrol();
    }
}




