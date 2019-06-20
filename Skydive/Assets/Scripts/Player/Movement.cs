using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
   //used for referencing the location of the knob
    public TrackMouse knob;
    float speedX;
    float speedY;
    public RectTransform knobBase;

    // speed adjustment : the higher it is, the faster you go
    [SerializeField] float alt = 1;

    void FixedUpdate()
    {
        //used to determine when the finger has left the perimeter of the circle
        float c = knob.c;
        if (Input.touchCount == 1 || Input.GetKey(KeyCode.Mouse0))
        {
            speedX = -knob.x / Screen.width * alt;
            speedY = -knob.y / Screen.height * alt;

            //while inside the circle the speed is adjustable
            if (c < knobBase.sizeDelta.x / 2.7f)
            {
                transform.Translate(new Vector3(speedX, speedY));
            }

            //while outside the circle the speed is not adjustable (velocity is)
            else
            {
                transform.Translate(new Vector3(speedX, speedY).normalized * 0.13f * alt);
            }
        }
    }
}
