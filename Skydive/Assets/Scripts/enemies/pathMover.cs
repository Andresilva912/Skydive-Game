using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pathMover : MonoBehaviour
{
    public float mod = 10;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, -mod * Time.deltaTime),Space.World); 
    }
}
