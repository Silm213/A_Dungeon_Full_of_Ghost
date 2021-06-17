using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletExpDie : MonoBehaviour
{
    public float TimeToDie = 3f;
    
    void Update()
    {
        if (TimeToDie <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            TimeToDie -= Time.deltaTime;
        }
    }
}
