using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float a = +0.5f;   
    float speed = 0.1f;
    float acceleration = 0.1f; 
    void Start()
    {
        
        
    }

    void Update()
    {
        if (speed < 1)
        {
            speed += acceleration * Time.deltaTime;
        }

        transform.rotation = Quaternion.Euler(new Vector3(-180, a, 0));
        a += speed; 
        
    }
}
