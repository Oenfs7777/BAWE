using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawSkill : Skill
{
    public void ClawActive()
    {
        Player_Anim.SetTrigger("IsBeastHit");
        cdTime = 30;
        Debug.Log("claw used");
    }
}