﻿using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SnakeLife : MonoBehaviour
{
    int time = 10;
    int TimeBuff = 0;
    public GameObject SnakeBody;

    List<GameObject> SnakeTail = new List<GameObject>();
    public int snakeScore = 0;
    public Vector2 direction = new Vector2(0, 0);

    float speed = 3;
   
     

   public void addChank()
    {
        Vector3 position = transform.position;

        if (SnakeTail.Count > 0)
        {
            position = SnakeTail[SnakeTail.Count - 1].transform.position;
        }

        position.y += 0.5f;
        GameObject lastTailChank = Instantiate(SnakeBody, position, Quaternion.identity) as GameObject;
        SnakeTail.Add(lastTailChank);


    }
    
    void snakeStep()
    {
        if (direction.x != 0 || direction.y != 0) 
        {
            Rigidbody componentRigid = GetComponent<Rigidbody>();
            componentRigid.velocity = new Vector3(direction.x*speed, direction.y*speed, 0);
            
            if (SnakeTail.Count > 0)
            {
                SnakeTail[0].transform.position = transform.position;

                for(int i = SnakeTail.Count-1; i>0; i--)
                {
                    SnakeTail[i].transform.position = SnakeTail[i - 1].transform.position;
                }
            }
        }
    }

    // Update is called once per frame
    void Start()
    {
          for(int i = 0; i<5; i++)
        {
            addChank();
        }
    }
    // Start is called before the first frame update
    void Update()
    {
        TimeBuff++;
        if(TimeBuff>=time){
            snakeStep();
            TimeBuff = 0;
        }

    }
}











