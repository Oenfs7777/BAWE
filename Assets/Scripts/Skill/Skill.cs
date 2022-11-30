using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{
    public float cdTime;
    public float activeTime;

    void Start()
    {
        ShieldSkill shieldSkill = new ShieldSkill();
        ChainSkill chainSkill = new ChainSkill();
        HealSkill healSkill = new HealSkill();
        AtkBuffSkill atkBuffSkill = new AtkBuffSkill();
        FlySkill flySkill = new FlySkill();
        ThunderSkill thunderSkill = new ThunderSkill();
        ClawSkill clawSkill = new ClawSkill();
    }
    public void UseSkill(int a)
    {

    }
}
