using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondsUpdate : MonoBehaviour
{
    float timeStartOffset = 0;
    bool getStartTime = false;
    
    void Update()
    {
        if(!getStartTime)
        {
            timeStartOffset = Time.realtimeSinceStartup;
            getStartTime = true;
        }

        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, Time.realtimeSinceStartup - timeStartOffset);


    }
}
