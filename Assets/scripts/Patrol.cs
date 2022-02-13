using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour

{
    public Transform[] waypoints; 
    public Animator animator;
    public int speed;


    private int waypointIndex;
    private float dist;
    // Start is called before the first frame update
    void Start()
    {
        
        waypointIndex = 0;
        transform.LookAt(waypoints[waypointIndex].position);
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetTrigger("Walk_Cycle_1");
       dist = Vector3.Distance(transform.position, waypoints[waypointIndex].position);
       if(dist < 1f)
       {
           Increase();
       }
       Patroling();
    }

    void Patroling()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }

    void Increase()
    {
        waypointIndex++;
        if(waypointIndex>= waypoints.Length){
            waypointIndex = 0;
        }
        transform.LookAt(waypoints[waypointIndex].position);
    }
}
