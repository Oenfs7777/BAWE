using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldSkill : Skill
{

    public void ShieldActive()
    {
        Player_Anim.SetTrigger("IsShield");
        cdTime = 15;
        Debug.Log("shield used");
    }
}