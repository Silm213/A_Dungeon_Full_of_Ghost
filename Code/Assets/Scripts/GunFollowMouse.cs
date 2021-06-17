using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFollowMouse : MonoBehaviour
{
    public Vector3 mousePos;
    public Vector3 gunPos;
    public float angle;
    
    // Update is called once per frame
    void Update()
    {
        mousePos = Input.mousePosition;
        gunPos = Camera.main.WorldToScreenPoint(transform.position);
        mousePos.x = mousePos.x - gunPos.x;
        mousePos.y = mousePos.y - gunPos.y;
        angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        if (angle > 90 && angle < 180 || angle <= -90)
        {
            transform.Rotate(180f, 0f, 0f);
        }
        else if(angle <= 90 && angle >-90)
        {
            transform.Rotate(0f, 0f, 0f);
        }
        
        
    }

    
}
