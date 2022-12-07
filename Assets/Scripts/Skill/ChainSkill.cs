using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainSkill : Skill
{
   
    public void ChainActive()
    {
        
        Player_Anim.SetTrigger("IsChian");
        cdTime = 12;
        Debug.Log("chain used");
    }
}
