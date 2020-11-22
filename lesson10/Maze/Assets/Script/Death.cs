using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Player find the exit of maze");
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("gg");
            Destroy(collision.gameObject);
        }
    }
}
