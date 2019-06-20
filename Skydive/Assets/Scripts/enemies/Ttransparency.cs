using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ttransparency : MonoBehaviour
{
    //once the cubes pass a certain location on the z axis, they will begin to fade into nothing
    public bool doDie;
    public float fadeRate;
    void Update()
    {
        Color alpha = this.GetComponent<MeshRenderer>().material.color;
        
        if (transform.position.z < 10)
        {
            alpha.a -= fadeRate * Time.deltaTime;
        }
        this.GetComponent<MeshRenderer>().material.color = alpha;

        doDie = this.GetComponent<MeshRenderer>().material.color.a <= 0.01f;

        if(doDie)
        {
            Destroy(this.gameObject);
        }
    }
}
