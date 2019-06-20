using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ttransparency : MonoBehaviour
{
    //once the cubes pass a certain location on the z axis, they will begin to fade into nothing

    //Eventually, this will be rewritten and destoy will also be added to it
    void Update()
    {
        Color alpha = this.GetComponent<MeshRenderer>().material.color;
        
        if (transform.position.z < 10)
        {
            alpha.a -= 4 * Time.deltaTime;
        }
        this.GetComponent<MeshRenderer>().material.color = alpha;
    }
}
