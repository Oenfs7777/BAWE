using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    private float ShotRate = 5.0f;
    private float ShotTime;
    public GameObject bullet;
    private Animator Slime_anim;

    public void Update()
    {
        Slime_anim = GetComponent<Animator>();
        ShotTime += Time.deltaTime;
        if (ShotTime > ShotRate)
        {
            Slime_anim.SetTrigger("SlimeAtk");
            ShotTime = 0;
        }
    }

    void Atk()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "chian(Clone)")
        {
            TimeStop();
            Invoke("TimeCount",2f);
        }
    }

    public void TimeStop()
    {
        Slime_anim.speed = 0;
    }

    public void TimeCount()
    {
        Slime_anim.speed = 1;
    }
}
