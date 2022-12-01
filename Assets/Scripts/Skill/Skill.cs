using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{
    public float cdTime;
    public float activeTime;

    public void ActTime()
    {

    }

    public void UseSkill(int a)
    {
        if (a == 1)
        {
            ShieldSkill shieldSkill = new ShieldSkill();
            shieldSkill.ShieldActive();
        }
        else if (a == 2)
        {
            ChainSkill chainSkill = new ChainSkill();
            chainSkill.ChainActive();
        }
        else if (a == 3)
        {
            HealSkill healSkill = new HealSkill();
            healSkill.HealActive();
        }
        else if (a == 4)
        {
            AtkBuffSkill atkBuffSkill = new AtkBuffSkill();
            atkBuffSkill.AtkBuffActive();
        }
        else if (a == 5)
        {
            FlySkill flySkill = new FlySkill();
            flySkill.FlyActive();
        }
        else if (a == 6)
        {
            ThunderSkill thunderSkill = new ThunderSkill();
            thunderSkill.ThunderActive();
        }
        else if (a == 7)
        {
            ClawSkill clawSkill = new ClawSkill();
            clawSkill.ClawActive();
        }
    }
}