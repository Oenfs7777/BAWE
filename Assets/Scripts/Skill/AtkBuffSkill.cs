using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtkBuffSkill : Skill
{
    public void AtkBuffActive()
    {
        Player_Anim.SetTrigger("IsCure");
        cdTime = 18;
        Debug.Log("aktBuff used");
    }
}