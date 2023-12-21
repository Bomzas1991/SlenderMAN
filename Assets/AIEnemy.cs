using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIEnemy : MonoBehaviour
{
    public Transform target;
    public float speed = 5;
    public float viewDistance = 15;
    public float wanderDistance = 5;

    Rigidbody rb;
    NavMeshAgent agent;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        //transform.LookAt(target);
        //transform.position += Vector3.forward * speed * Time.deltaTime;
        //rb.velocity = transform.forward * speed;


        var distance = Vector3.Distance(transform.position, target.position);

        if (distance < viewDistance)
        {
            //CHASE
            agent.destination = target.position;
        }

        else
        {
            //SEEK
            if (agent.velocity == Vector3.zero)
            {
                agent.destination = Random.insideUnitSphere * wanderDistance;
            }
        }
    }
}
