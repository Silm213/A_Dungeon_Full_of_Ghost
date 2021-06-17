using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firepoint;
    public Transform firepoint1;
    [Space]
    public GameObject bullet;
    [Space]
    private float timebtwshoot;
    public float startTime;
    [Space]
    public AudioClip SoundToPlay;
    AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {

        if (timebtwshoot <= 0)
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                Shoot();
                timebtwshoot = startTime;
            }

        }
        else
        {
            timebtwshoot -= Time.deltaTime;
        }
    }

    void Shoot()
    {
        Instantiate(bullet, firepoint.position, firepoint.rotation);
        Instantiate(bullet, firepoint1.position, firepoint1.rotation);
        

        audio.PlayOneShot(SoundToPlay);
    }
}
