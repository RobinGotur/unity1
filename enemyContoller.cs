using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class enemyContoller : MonoBehaviour
{
    public Transform playerObj;
    protected NavMeshAgent enemyMesh;
    private Camera mainCamera;
    private Coroutine coroutine;
    // Start is called before the first frame update
    void Start()
    {
        enemyMesh = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyMesh.SetDestination(playerObj.position);
    }
    
      
    
}
