using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ttransparency : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Color alpha = this.GetComponent<MeshRenderer>().material.color;
        //23 for test
        //
        if (transform.position.z < 10)
        {
            alpha.a -= 4 * Time.deltaTime;
        }
        this.GetComponent<MeshRenderer>().material.color = alpha;
    }
}
