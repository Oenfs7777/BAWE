using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainSkill : Skill
{
    public void ChainActive()
    {
        ActTime();
        Player_Anim.SetTrigger("IsChian");
        Debug.Log("chain used");
    }
}
