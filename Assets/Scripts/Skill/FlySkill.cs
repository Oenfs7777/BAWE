using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlySkill : Skill
{
    public void FlyActive()
    {
        ActTime();
        Debug.Log("fly used");
    }
}
