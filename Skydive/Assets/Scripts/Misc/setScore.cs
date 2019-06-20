

using System.Collections;
using UnityEngine;
using TMPro;

public class setScore : MonoBehaviour
{

    public TextMeshProUGUI score;
    public TextMeshProUGUI highScore;
    float time;

   
    void Update()
    {
        time += Time.deltaTime;
        score.SetText("Seconds: " + (int)time);
    }

}