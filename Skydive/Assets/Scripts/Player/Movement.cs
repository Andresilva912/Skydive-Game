using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public TrackMouse knob;
    [SerializeField] Rigidbody player;
    float speedX;
    float speedY;
    [SerializeField] float alt = 1;

    void Update()
    {

        float c = knob.c;
        //Debug.Log(c);
        if (Input.touchCount == 1 || Input.GetKey(KeyCode.Mouse0))
        {
            speedX = -knob.x / Screen.width * alt;
            speedY = -knob.y / Screen.height * alt;
            if (c < 175)
            {
                transform.Translate(new Vector3(speedX, speedY));
            }
            else
            {
                transform.Translate(new Vector3(speedX, speedY).normalized * 0.13f);
            }
        }
        Debug.Log(speedY / speedX);
    }
}
