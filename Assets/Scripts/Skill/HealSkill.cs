using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealSkill : Skill
{
    public void HealActive()
    {
        ActTime();
        Player_Anim.SetTrigger("IsCure");
        Debug.Log("heal used");
    }
}