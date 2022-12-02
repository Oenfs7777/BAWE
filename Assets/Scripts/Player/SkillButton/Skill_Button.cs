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

    public void Skill1() //Å@¬Þ
    {
        Player_Anim.SetTrigger("IsShield");
    }

    public void Skill2() // ÂêÃì
    {
        Player_Anim.SetTrigger("IsChian");
    }

    public void Skill3() //«ì´_
    {
        Player_Anim.SetTrigger("IsCure");
    }

    public void Skill4() //§ðÀ»buff
    {
        Player_Anim.SetTrigger("IsAtkBuff");
    }

    public void BSkill1() //°{¹q
    {
        Player_Anim.SetTrigger("IsThunder");
    }

    public void BSkil2() //Ã~¤ö
    {
        Player_Anim.SetTrigger("IsBeastHit");
    }


    public void skill()
    {
        Debug.Log("test");
    }
}
