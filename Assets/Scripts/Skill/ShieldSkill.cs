using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldSkill : Skill
{
    public void ShieldActive()
    {
        ActTime();
        Debug.Log("shield used");
    }
}