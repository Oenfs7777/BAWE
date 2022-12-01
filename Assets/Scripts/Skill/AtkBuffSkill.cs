using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtkBuffSkill : Skill
{
    public void AtkBuffActive()
    {
        ActTime();
        Debug.Log("aktBuff used");
    }
}
