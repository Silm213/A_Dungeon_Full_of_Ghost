using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CH_Stats : MonoBehaviour
{
    static float HP;
    static float StartHP = 100;
    public Image healthbar;

    private void Start()
    {
        HP = StartHP;
    }

    void Update()
    {
       healthbar.fillAmount = HP/StartHP;
    }
    private void FixedUpdate()
    {
        HP -= Time.fixedDeltaTime;
    }

    public void TakingDamege(float dmg)
    {
        HP -= dmg;
        
        if (HP <= 0)
        {
            Destroy(gameObject);
            MonstersSpawnerControl.spawnAllowed = false;
            healthbar.fillAmount = 0;
        }
    }

    public static void AddHP(float hp)
    {
        if (HP < StartHP)
        {
            if (StartHP - HP >= 10)
                HP += hp;
            else
                HP += StartHP - HP;
            
        }   
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            TakingDamege(1);
        }
    }
}
