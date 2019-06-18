using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    void Update()
    {
        float x;
        float y;

        //mouse pos to canvas pos
        Vector2 mousePos = Camera.main.ScreenToViewportPoint(Input.mousePosition);

        //creates artifical origin in the objects center
        x = -transform.position.x + mousePos.x * Screen.width;
        y = -transform.position.y + mousePos.y * Screen.height;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, (Mathf.Atan2(y, x) * 180 / Mathf.PI) - 90));
    }
}
