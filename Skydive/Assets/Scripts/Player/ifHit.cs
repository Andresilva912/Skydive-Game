using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ifHit : MonoBehaviour
{
    //restarts game if hit
    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("GameScene");
    }
}
