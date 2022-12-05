using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealSkill : Skill
{
    public void HealActive()
    {
        Player_Anim.SetTrigger("IsCure");
        cdTime = 15;
        Debug.Log("heal used");
    }
}