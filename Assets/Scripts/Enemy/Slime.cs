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
}
