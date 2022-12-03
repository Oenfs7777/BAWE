using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtkBuffSkill : Skill
{
    public void AtkBuffActive()
    {
        ActTime();
        Player_Anim.SetTrigger("IsCure");
        Debug.Log("aktBuff used");
    }
}