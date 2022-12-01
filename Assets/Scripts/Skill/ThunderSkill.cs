using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderSkill : Skill
{
    public void ThunderActive()
    {
        ActTime();
        Debug.Log("thunder used");
    }
}
