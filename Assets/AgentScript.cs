using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentScript : MonoBehaviour
{

    public Animator animator;

    public Transform goal;

    NavMeshAgent agent;
        
    
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>(); //5 
    }

    // Update is called once per frame
    void Update()
    {
        
        agent.destination = goal.position; //6 

        animator.SetFloat("Speed_f", agent.velocity.magnitude);//7

    }
}
