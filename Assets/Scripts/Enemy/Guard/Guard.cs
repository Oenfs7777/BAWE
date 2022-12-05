using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guard : MonoBehaviour
{
    private Transform BattleR;

    private float FlipTime;
    private float FlipTimetarget = 1.5f;
    public bool flip = true;
    public Player GetPlayer;
    public GameObject Arror;
    public GameObject BB;
    public Transform GAtkpoint;
    public Transform BAtkpoint;
    private Animator Guard_anim;

    private float ShotRate = 3.0f;
    private float ShotTime;
    private int DoWhat;

    // Start is called before the first frame update
    void Start()
    {
        Guard_anim = gameObject.GetComponent<Animator>();
        BattleR = gameObject.GetComponent<Transform>();
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

    public void TF()
    {
        BattleR.position = new Vector3(1, 0, 0);
        transform.Rotate(0, 180, 0);
    }

    void Atk()
    {
        Instantiate(Arror, GAtkpoint.position, GAtkpoint.rotation);
    }

    void Bob()
    {
        Instantiate(BB, BAtkpoint.position, BAtkpoint.rotation);
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
            Guard_anim.SetTrigger("GAtk");
        }
        else if (DoWhat == 2)
        {
            Guard_anim.SetTrigger("GSBomb");
        }
        else if(DoWhat == 3)
        {
            Guard_anim.SetTrigger("TAtk");
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
        Guard_anim.speed = 0;
    }

    public void TimeCount()
    {
        Guard_anim.speed = 1;
    }
}
