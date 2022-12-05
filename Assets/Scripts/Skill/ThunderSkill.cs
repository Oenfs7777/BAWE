using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderSkill : Skill
{
    public void ThunderActive()
    {
        Player_Anim.SetTrigger("IsThunder");
        cdTime = 25;
        Debug.Log("thunder used");
    }
}