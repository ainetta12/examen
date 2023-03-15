using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour
{
    
    public float playerSpeed = 4f;
    public float jumpforce = 5f;

    public SpriteRenderer spriterenderer;
    private Rigidbody2D rBody;
    private GroundSensor sensor;
    float horizontal;
   
    // Start is called before the first frame update
    void Start()
    {
      
        sensor = GameObject.Find("GroundSensor").GetComponent <GroundSensor>();
        spriterenderer = GetComponent <SpriteRenderer>(); 
        rBody = GetComponent <Rigidbody2D>();
       
    
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        if(horizontal < 0)
        {
            spriterenderer.flipX = true;
        }
           
        else if(horizontal > 0)
        {
            spriterenderer.flipX = false;
        } 

        if(Input.GetButtonDown("Jump") && sensor.isGrounded)
        {
            rBody.AddForce(Vector2.up * jumpforce.ForceMode2D.impulse);
        }

    }

     void FixedUpdate ()
      {
        rBody.velocity = new Vector2 (horizontal * playerSpeed, rBody.velocity.y);
      }
}
