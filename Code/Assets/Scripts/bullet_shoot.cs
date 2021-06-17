using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_shoot : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;

    public GameObject projectile;
    
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D info)
    {
        if (info.gameObject.tag != "Bullet")
        {
            //Cos sie stanie gdy kula uderzy
            Instantiate(projectile, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        
    }
}
