using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_Button : MonoBehaviour
{
    public GameObject Player;
    public Animator Player_Anim;

    private void Start()
    {

    }

    public void Skill1() //�@��
    {
        Player_Anim.SetTrigger("IsShield");
    }

    public void Skill2() // ����
    {
        Player_Anim.SetTrigger("IsChian");
    }

    public void Skill3() //��_
    {
        Player_Anim.SetTrigger("IsCure");
    }

    public void Skill4() //����buff
    {
        Player_Anim.SetTrigger("IsAtkBuff");
    }

    public void BSkill1() //�{�q
    {
        Player_Anim.SetTrigger("IsThunder");
    }

    public void BSkil2() //�~��
    {
        Player_Anim.SetTrigger("IsBeastHit");
    }


    public void skill()
    {
        Debug.Log("test");
    }
}
