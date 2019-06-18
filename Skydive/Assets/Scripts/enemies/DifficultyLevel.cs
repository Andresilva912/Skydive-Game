using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyLevel : MonoBehaviour
{   
    public gridSpawn dif;
    float time;

    private void Start()
    {
        StartCoroutine(difInc());
     }

    IEnumerator difInc()
    {
        for (int i = 0; i < 8; i++)
        {
            dif.numSpawn += 1;
            yield return new WaitForSeconds(10);
        }
        
    }
}
