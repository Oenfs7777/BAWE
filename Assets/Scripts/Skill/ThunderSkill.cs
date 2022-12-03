using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderSkill : Skill
{
    public void ThunderActive()
    {
        ActTime();
        Player_Anim.SetTrigger("IsThunder");
        Debug.Log("thunder used");
    }
}