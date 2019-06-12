using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
   //used for referencing the location of the knob
    public TrackMouse knob;
    float speedX;
    float speedY;

   
    [SerializeField] float alt = 1;

    void Update()
    {
        //used to determine when the finger has left the presmises of the circle
        float c = knob.c;
        if (Input.touchCount == 1 || Input.GetKey(KeyCode.Mouse0))
        {
            speedX = -knob.x * alt / Screen.width ;
            speedY = -knob.y * alt / Screen.height;

            //while inside the circle the speed is adjustable
            if (c < 175)
            {
                transform.Translate(new Vector3(speedX, speedY));
            }

            //while outside the circle the speed is not adjustable (velocity is)
            else
            {
                transform.Translate(new Vector3(speedX, speedY).normalized * 0.13f / alt);
            }
        }
    }
}
