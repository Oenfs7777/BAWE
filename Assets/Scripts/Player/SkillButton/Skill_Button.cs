using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_Button : MonoBehaviour
{
    public GameObject Player;
    public Animator Player_Anim;
    public float ShotTime;
    public float ShotRate = 5f;


    public void Skill1() //護盾
    {
        Player_Anim.SetTrigger("IsShield");
        Debug.Log("Shield");
    }

    public void Skill2() // 鎖鏈
    {
        Player_Anim.SetTrigger("IsChian");
        Debug.Log("Chian");
    }

    public void Skill3() //恢復
    {
        Player_Anim.SetTrigger("IsCure");
        Debug.Log("Cure");
    }

    public void Skill4() //Atkbuff
    {
        Player_Anim.SetTrigger("IsAtkBuff");
        AtkUp();
        Invoke("AtkUpStop", 10f);
        Debug.Log("AtkUp");
    }

    public void BSkill1() //雷爆
    {
        Player_Anim.SetTrigger("IsThunder");
        Debug.Log("Thunder");
    }

    public void BSkil2() //獸爪
    {
        Player_Anim.SetTrigger("IsBeastHit");
        Debug.Log("BeastHit");
    }

    public void AtkUpStop()
    {
        Player_Anim.SetBool("IsAtkUp", false);
    }

    public void AtkUp()
    {
        Player_Anim.SetBool("IsAtkUp", true);
    }
}
