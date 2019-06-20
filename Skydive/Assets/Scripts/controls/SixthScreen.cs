using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SixthScreen : MonoBehaviour
{
    public RectTransform size;
    public float width;
    public float height;

    void Awake()
    {
        //creates ratio which uses Screen size, therefore making a common size for all screens
        float screenScl = (Screen.height / 2500f);

        //puts the joystick in the horizontal center, and 1/13th up vertically
        transform.position = new Vector2(width * Screen.width, height * Screen.height);

        //utilizes the ratio to make a size of the joystick
        size.sizeDelta *= new Vector2(screenScl, screenScl);
    }
}
 