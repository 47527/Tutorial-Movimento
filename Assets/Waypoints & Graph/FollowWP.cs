using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowWP : MonoBehaviour
{
    public GameObject[] waypoints;
    int curretnWP = 0;

    public float speed = 10.0f;
    public float rotSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(this.transform.position, waypoints[curretnWP].transform.position) < 3)
            curretnWP++;

        if (curretnWP >= waypoints.Length)
            curretnWP = 0;

        //this.transform.LookAt(waypoints[curretnWP].transform);
        Quaternion lookatWP = Quaternion.LookRotation(waypoints[curretnWP].transform.position - this.transform.position);
        this.transform.rotation = Quaternion.Slerp(transform.rotation, lookatWP, rotSpeed * Time.deltaTime);

        this.transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
