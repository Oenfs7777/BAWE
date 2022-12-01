using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainSkill : Skill
{
    public void ChainActive()
    {
        ActTime();
        Debug.Log("chain used");
    }
}
