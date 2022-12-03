using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldSkill : Skill
{
    public void ShieldActive()
    {
        ActTime();
        Player_Anim.SetTrigger("IsShield");
        Debug.Log("shield used");
    }
}