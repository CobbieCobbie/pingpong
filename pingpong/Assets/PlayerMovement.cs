using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float force;
    public Rigidbody rb;

    void Start()
    { 
        rb.AddForce(new Vector3(0, 50, 0));
    }

    void Update()
    {
        if (Input.GetKey("d"))
        {
            rb.AddForce(new Vector3(
                force * Time.deltaTime,
                0,
                0
                ));
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(new Vector3(
                - force * Time.deltaTime,
                0,
                0
                ));
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(new Vector3(
                0,
                0,
                -force * Time.deltaTime
                ));
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(new Vector3(
                0,
                0,
                force * Time.deltaTime
                ));
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(new Vector3(
                0,
                force * Time.deltaTime,
                0
                ));
        }
    }
}
