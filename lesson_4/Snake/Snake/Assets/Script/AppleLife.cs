using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleLife : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-7.5f, 7.5f);
        float y = Random.Range(-5.5f, 5.5f);

        transform.position = new Vector3(x, y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        SnakeLife s = collision.gameObject.GetComponent<SnakeLife>();
        if (s != null)
        {
            s.addChank();
            s.snakeScore++;
            Destroy(gameObject);
        }
    }
}

