using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkillTest : MonoBehaviour
{
    public int useSkill1, useSkill2, useSkill3;
    public GameObject player;
    public Animator animator;
    // Skill skill = new Skill();

    // Start is called before the first frame update
    void Start()
    {
        Skill skill = player.AddComponent<Skill>();
        useSkill1 = PlayerPrefs.GetInt("SkillSlot_1");
        useSkill2 = PlayerPrefs.GetInt("SkillSlot_2");
        useSkill3 = PlayerPrefs.GetInt("SkillSlot_3");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            UseSkill(useSkill1);
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            UseSkill(useSkill2);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            UseSkill(useSkill3);
        }
    }
    void UseSkill(int a)
    {
        if (a == 1)
        {
            ShieldSkill shieldSkill = new ShieldSkill();
            shieldSkill.Player = player;
            shieldSkill.Player_Anim = animator;
            shieldSkill.ShieldActive();
        }
        else if (a == 2)
        {
            ChainSkill chainSkill = new ChainSkill();
            chainSkill.Player = player;
            chainSkill.Player_Anim = animator;
            chainSkill.ChainActive();
        }
        else if (a == 3)
        {
            HealSkill healSkill = new HealSkill();
            healSkill.Player = player;
            healSkill.Player_Anim = animator;
            healSkill.HealActive();
        }
        else if (a == 4)
        {
            AtkBuffSkill atkBuffSkill = new AtkBuffSkill();
            atkBuffSkill.Player = player;
            atkBuffSkill.Player_Anim = animator;
            atkBuffSkill.AtkBuffActive();
        }
        else if (a == 5)
        {
            FlySkill flySkill = new FlySkill();
            flySkill.Player = player;
            flySkill.Player_Anim = animator;
            flySkill.FlyActive();
        }
        else if (a == 6)
        {
            ThunderSkill thunderSkill = new ThunderSkill();
            thunderSkill.Player = player;
            thunderSkill.Player_Anim = animator;
            thunderSkill.ThunderActive();
        }
        else if (a == 7)
        {
            ClawSkill clawSkill = new ClawSkill();
            clawSkill.Player = player;
            clawSkill.Player_Anim = animator;
            clawSkill.ClawActive();
        }
    }
}