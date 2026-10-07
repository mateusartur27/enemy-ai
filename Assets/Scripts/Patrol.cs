using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    public GameObject point;
    NavMeshAgent agent;
    Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        ToPatrol();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(agent.velocity.magnitude);animator.SetFloat("Speed", agent.velocity.magnitude);
    }

    void ToPatrol()
    {
        agent.SetDestination(point.transform.position);
        

    }



}
