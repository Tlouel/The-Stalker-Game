using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMovement : MonoBehaviour
{

    private NavMeshAgent enemy;
    
    public GameObject player;
    public bool isEnemySeen;

    
    void Start()
    {
       
        enemy = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
         if(isEnemySeen)
        {
            enemy.GetComponent<NavMeshAgent>().enabled = false;
        }
        else
        {
            enemy.GetComponent<NavMeshAgent>().enabled = true;
            enemy.transform.LookAt(player.transform.position);
            enemy.SetDestination(player.transform.position);
        }
       
    }

    void OnBecameVisible()
    {
        isEnemySeen = true; 
    }

    void OnBecameInvisible()
    {
        isEnemySeen = false;
    }


}
