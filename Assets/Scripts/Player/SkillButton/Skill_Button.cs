using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_Button : MonoBehaviour
{
    public GameObject Player;
    public Animator Player_Anim;


    public void Skill1() //�@��
    {
        Player_Anim.SetTrigger("IsShield");
        Debug.Log("Shield");
    }

    public void Skill2() // ����
    {
        Player_Anim.SetTrigger("IsChian");
        Debug.Log("Chian");
    }

    public void Skill3() //��_
    {
        Player_Anim.SetTrigger("IsCure");
        Debug.Log("Cure");
    }

    public void Skill4() //����buff
    {
        Player_Anim.SetTrigger("IsAtkBuff");
        Player_Anim.SetBool("IsAtkUp", true);
        Debug.Log("AtkUp");
    }

    public void BSkill1() //�{�q
    {
        Player_Anim.SetTrigger("IsThunder");
        Debug.Log("Thunder");
    }

    public void BSkil2() //�~��
    {
        Player_Anim.SetTrigger("IsBeastHit");
        Debug.Log("BeastHit");
    }
}
