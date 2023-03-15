using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{

    private Mario mario;
    public bool isGrounded;

    void  Start()
    {
        mario = GetComponent<Mario>();

    }

    void  OnTriggerEnter2D(Collider2D other)
    {
       
       if(GameObject.layer == 3)
       {
        isGrounded = true;
       }

    }
}
