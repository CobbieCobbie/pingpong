﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(new Vector3(0,200,500));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
