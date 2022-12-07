using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bmage : MonoBehaviour
{
    private float ShotRate = 5.0f;
    private float ShotTime;

    private float FlipTime;
    private float FlipTimetarget = 1.5f;

    public GameObject Bbullet;
    private Animator B_anim;
    public Player GetPlayer;
    public bool flip = false;

    public void Start()
    {

    }

    public void Update()
    {
        B_anim = GetComponent<Animator>();

        if (ShotTime > ShotRate)
        {
            B_anim.SetTrigger("BlueAtk");
            ShotTime = 0;
        }

        if (FlipTime > FlipTimetarget)
        {
            FlipYes();
            FlipNo();

            FlipTime = 0;
        }
        FlipTime += Time.deltaTime;
        ShotTime += Time.deltaTime;
    }


    void BAtk()
    {
        Instantiate(Bbullet, transform.position, Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "chian(Clone)")
        {
            TimeStop();
            Invoke("TimeCount", 2f);
        }
        else if (collision.tag == "Thunder")
        {
            TimeStop();
            Invoke("TimeCount", 1f);
        }
    }

    public void TimeStop()
    {
        B_anim.speed = 0;
    }

    public void TimeCount()
    {
        B_anim.speed = 1;
    }

    public void FlipYes()
    {
        if (flip == true)
        {
            if (GetPlayer.currentPos == Pos.DL || GetPlayer.currentPos == Pos.UL)
            {
                transform.Rotate(0, 180, 0);
                flip = false;
            }
        }
    }

    public void FlipNo()
    {
        if (flip == false)
        {
            if (GetPlayer.currentPos == Pos.DR || GetPlayer.currentPos == Pos.UR)
            {
                transform.Rotate(0, 180, 0);
                flip = true;
            }
        }
    }
}
