﻿using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    { 
        if (Input.GetAxis("Horizontal")<0){
            GetComponent<Rigidbody>().velocity += new Vector3(0.5f, 0, 0);
        
    }else if (Input.GetAxis("Horizontal") > 0)
        {
            GetComponent<Rigidbody>().velocity -= new Vector3(0.5f, 0, 0);
        }

        if (Input.GetAxis("Vertical") < 0)
        {
            GetComponent<Rigidbody>().velocity += new Vector3(0, 0, 0.5f);
        }
        else if (Input.GetAxis("Vertical") > 0)
        {
            GetComponent<Rigidbody>().velocity -= new Vector3(0, 0, 0.5f);
        }


    }
}
