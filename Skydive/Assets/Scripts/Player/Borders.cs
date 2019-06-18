using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borders : MonoBehaviour
{
    public Transform up;
    public Transform down;
    public Transform left;
    public Transform right;

    void Update()
    {
        if(transform.position.x >= right.position.x)
        {
            transform.position = new Vector3(right.position.x, transform.position.y, transform.position.z);
        }
        if(transform.position.x <= left.position.x)
        {
            transform.position = new Vector3(left.position.x, transform.position.y,  transform.position.z);
        }
        if(transform.position.y >= up.position.y)
        {
            transform.position = new Vector3(transform.position.x,   up.position.y,  transform.position.z);
        }
        if(transform.position.y <= down.position.y)
        {
            transform.position = new Vector3(transform.position.x, down.position.y,  transform.position.z);
        }
    }
}
