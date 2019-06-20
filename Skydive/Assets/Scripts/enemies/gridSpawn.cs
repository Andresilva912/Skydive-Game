using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridSpawn : MonoBehaviour
{
    public GameObject cube;
    public float spawnTime;
    public int numSpawn;

    private void Start()
    {
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
       while(true)
        {
            RandomSpawn(numSpawn);
            yield return new WaitForSeconds(spawnTime);
        }
    }

    void RandomSpawn(int num)
    {
        int[] check  = new int[num];
        Vector3 placement = new Vector3(0, 0, 0);
        //Debug.Log(check.Length);
        for (int i = 0; i < num; i++)
        {
            int x = (int)Random.Range(1, 10);
            for(int j = 0; j < num; j++)
            {
                int tempNum = check[j];
                if (tempNum == x || check[0] == x)
                {
                    x = (int)Random.Range(1, 10);
                    j = 0;
                }
            }

            check[i] = x;

            switch (x)
            {
                case 1:
                    //Debug.Log(1);
                    Instantiate(cube, transform.position + new Vector3(-2.75f, 3.75f), Quaternion.identity);
                    break;
                case 2:
                    //Debug.Log(2);
                    Instantiate(cube, transform.position + new Vector3(0f, 3.75f), Quaternion.identity);
                    break;
                case 3:
                    //Debug.Log(3);
                    Instantiate(cube, transform.position + new Vector3(2.75f, 3.75f), Quaternion.identity);
                    break;
                case 4:
                    //Debug.Log(4);
                    Instantiate(cube, transform.position + new Vector3(-2.75f, 1), Quaternion.identity);
                    break;
                case 5:
                    //Debug.Log(5);
                    Instantiate(cube, transform.position + new Vector3(0f, 1f), Quaternion.identity);
                    break;
                case 6:
                    //Debug.Log(6);
                    Instantiate(cube, transform.position + new Vector3(2.75f, 1), Quaternion.identity);
                    break;
                case 7:
                    //Debug.Log(7);
                    Instantiate(cube, transform.position + new Vector3(-2.75f, -1.75f), Quaternion.identity);
                    break;
                case 8:
                    //Debug.Log(8);
                    Instantiate(cube, transform.position + new Vector3(0f, -1.75f), Quaternion.identity);
                    break;
                case 9:
                    //Debug.Log(9);
                    Instantiate(cube, transform.position + new Vector3(2.75f, -1.75f), Quaternion.identity);
                    break;
            }
        }
    }
}
