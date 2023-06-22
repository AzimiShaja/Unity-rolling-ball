using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
     public Rigidbody rb;

     public float forwordForce = 2000;
     public float sideWaysForce  = 500;
    // Start is called before the first frame update
    void Start()
    {
    
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwordForce * Time.deltaTime);

        if (Input.GetKey("d")) 
        {
            rb.AddForce(sideWaysForce * Time.deltaTime ,0,0);
        } 
        else if (Input.GetKey("a")) 
        {
            rb.AddForce(-sideWaysForce * Time.deltaTime, 0, 0);
        }
    }
}
