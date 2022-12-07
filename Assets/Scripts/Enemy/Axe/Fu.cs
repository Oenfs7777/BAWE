using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fu : MonoBehaviour
{
    private Transform BattleR;
    public Transform SFpoint;

    private float FlipTime;
    private float FlipTimetarget = 1.2f;
    public bool flip = true;
    public Player GetPlayer;
    public GameObject SF;
    private Animator Fu_anim;

    private float ShotRate = 3.0f;
    private float ShotTime;
    private int DoWhat;

    // Start is called before the first frame update
    void Start()
    {
        Fu_anim = gameObject.GetComponent<Animator>();
        BattleR = gameObject.GetComponent<Transform>();
        TF();
    }

    // Update is called once per frame
    void Update()
    {

        if (ShotTime > ShotRate)
        {
            DoWhat = Random.Range(1, 4);
            DoAnim();
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

    void SFAtk()
    {
        Instantiate(SF, SFpoint.position, SFpoint.rotation);
    }

    public void TF()
    {
        transform.Rotate(0, 180, 0);
    }

    public void FlipYes()
    {
        if (flip == true)
        {
            if (GetPlayer.currentPos == Pos.DR || GetPlayer.currentPos == Pos.UR)
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
            if (GetPlayer.currentPos == Pos.DL || GetPlayer.currentPos == Pos.UL)
            {
                transform.Rotate(0, 180, 0);
                flip = true;
            }
        }
    }

    public void DoAnim()
    {
        if (DoWhat == 1)
        {
            Fu_anim.SetTrigger("IsCi");
        }
        else if (DoWhat == 2)
        {
            Fu_anim.SetTrigger("Ishuikan");
        }
        else if (DoWhat == 3)
        {
            Fu_anim.SetTrigger("Isshufu");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "chian(Clone)")
        {
            TimeStop();
            Invoke("TimeCount", 2f);
        }
    }

    public void TimeStop()
    {
        Fu_anim.speed = 0;
    }

    public void TimeCount()
    {
        Fu_anim.speed = 1;
    }
}
