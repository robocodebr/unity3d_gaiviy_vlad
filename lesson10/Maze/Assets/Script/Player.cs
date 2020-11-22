using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }
    private Rigidbody rg;
    float speed = 1000;
    // Update is called once per frame
    void FixedUpdate()
    { 
        if (Input.GetAxis("Horizontal")<0){
            rg.AddForce(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
            // GetComponent<Rigidbody>().velocity += new Vector3(0.5f, 0, 0);

        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            rg.AddForce(new Vector3(1, 0, 0) * speed * Time.deltaTime);
            // GetComponent<Rigidbody>().velocity -= new Vector3(0.5f, 0, 0);
        }

        if (Input.GetAxis("Vertical") < 0)
        {
            rg.AddForce(new Vector3(0, 0, -1) * speed * Time.deltaTime);
           // GetComponent<Rigidbody>().velocity += new Vector3(0, 0, 0.5f);
        }
        else if (Input.GetAxis("Vertical") > 0)
        {
            rg.AddForce(new Vector3(0, 0, 1) * speed * Time.deltaTime);
            //GetComponent<Rigidbody>().velocity -= new Vector3(0, 0, 0.5f);
        }


    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Player find the exit of maze");
        if (collision.gameObject.tag == "Death")
        {
            Debug.Log("gg");
            Destroy(collision.gameObject);
        }
    }
}
