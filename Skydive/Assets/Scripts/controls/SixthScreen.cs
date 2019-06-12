using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SixthScreen : MonoBehaviour
{
    void Awake()
    {
        transform.position = new Vector2((1/2f) * Screen.width, (2/13f) * Screen.height);
    }

}
