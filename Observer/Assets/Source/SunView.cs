using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunView : MonoBehaviour
{
    public float orbitRadius = 4.0f; 
    public float speedFactor = 1.0f;  

    public void SunOrbit(float timeOfDay)
    {
        float angle = timeOfDay * 360-140; 
        float x = Mathf.Cos((angle * Mathf.Deg2Rad) * speedFactor) * orbitRadius;
        float y = Mathf.Sin((angle * Mathf.Deg2Rad) * speedFactor) * orbitRadius;

        transform.position = new Vector3(y,x, 0);
    }

}
