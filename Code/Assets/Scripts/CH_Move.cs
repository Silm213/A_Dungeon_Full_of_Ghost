using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CH_Move : MonoBehaviour
{
    public float movespeed = 5f;
    public float jump = 5f;
    public bool isGrounded = false;

    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += move * Time.deltaTime * movespeed;
        Jump();
    }

    //Skok
    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jump), ForceMode2D.Impulse);
        }
    }

    //Kiedy dotyka ziemi
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground")
             isGrounded = true;
    }

    //Kiedy nie dotyka ziemi
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground")
            isGrounded = false;
        
    }
}
