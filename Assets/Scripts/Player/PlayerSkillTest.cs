using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSkillTest : MonoBehaviour
{
    // 三個可選技能
    public int useSkill1, useSkill2, useSkill3;

    // 三張技能的圖片
    public GameObject button_1Img, button_2Img, button_3Img;

    // 所有技能的圖片
    public Sprite[] skillImgs = new Sprite[7];

    public GameObject player;
    public Animator animator;

    // 技能的 parent class 
    Skill skill = new Skill();

    // Start is called before the first frame update
    void Start()
    {
        Button btn1 = button_1Img.GetComponent<Button>();
        Button btn2 = button_2Img.GetComponent<Button>();
        Button btn3 = button_3Img.GetComponent<Button>();

        useSkill1 = PlayerPrefs.GetInt("SkillSlot_1");
        useSkill2 = PlayerPrefs.GetInt("SkillSlot_2");
        useSkill3 = PlayerPrefs.GetInt("SkillSlot_3");

        btn1.GetComponent<Image>().sprite = skillImgs[useSkill1];
        btn2.GetComponent<Image>().sprite = skillImgs[useSkill2];
        btn3.GetComponent<Image>().sprite = skillImgs[useSkill3];

    }

    // 給按鈕用
    public void Slot_1()
    {
        UseSkill(useSkill1);
    }
    public void Slot_2()
    {
        UseSkill(useSkill2);
    }
    public void Slot_3()
    {
        UseSkill(useSkill3);
    }

    // 使用 children class
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
            ClawSkill clawSkill = new ClawSkill();
            clawSkill.Player = player;
            clawSkill.Player_Anim = animator;
            clawSkill.ClawActive();
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
            FlySkill flySkill = new FlySkill();
            flySkill.Player = player;
            flySkill.Player_Anim = animator;
            flySkill.FlyActive();
        }
    }
}