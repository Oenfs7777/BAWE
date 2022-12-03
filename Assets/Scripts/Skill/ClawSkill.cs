using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawSkill : Skill
{
    public void ClawActive()
    {
        ActTime();
        Player_Anim.SetTrigger("IsBeastHit");
        Debug.Log("claw used");
    }
}