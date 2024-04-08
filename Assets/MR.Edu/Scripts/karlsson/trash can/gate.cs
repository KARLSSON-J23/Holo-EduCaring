using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gate : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject[] waypoints;
    [SerializeField] bool openGate = false;
    [SerializeField] float speed = 1f;

    
    int currentWaypointIndex = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].transform.position) < .1f)
        {
            
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
            openGate = false;
        }
        if(openGate)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime);
        }
        
    }
    public void moveDoor()
    {
        openGate = true;



    }
    public void goBack()
    {

    }
}
