using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDif : MonoBehaviour
{
    public gridSpawn dif;

    // Update is called once per frame
    void Update()
    {
        dif.numSpawn = Random.Range(4, 9);
    }
}
