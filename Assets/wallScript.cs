using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallScript : MonoBehaviour
{
    public float speed = 2f;
    public float minX = -3.5f;
    public float maxX = 3.5f;
    private int direction = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * direction * Time.deltaTime;
        if (pos.x > maxX)
        {
            pos.x = maxX;
            direction = -1;
        }
        else if (pos.x < minX)
        {
            pos.x = minX;
            direction = 1;
        }
        transform.position = pos;
    }
}
