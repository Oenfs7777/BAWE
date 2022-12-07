using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerSkillTest : MonoBehaviour
{
    [SerializeField]
    public Image imageCooldown1, imageCooldown2, imageCooldown3;
    [SerializeField]
    public TMP_Text textCooldown1, textCooldown2, textCooldown3;

    // 三個技能的冷卻時間
    public float cdTime;
    public float cooldownTime1, cooldownTime2, cooldownTime3;
    public bool isCooldown1, isCooldown2, isCooldown3;
    public float cooldownTimer1, cooldownTimer2, cooldownTimer3;
    public float circleTime1, circleTime2, circleTime3;

    // 三個可選技能
    public int useSkill1, useSkill2, useSkill3;

    // 三張技能的按鈕
    public Button button_1, button_2, button_3;

    // 所有技能的圖片
    public Sprite[] skillImgs = new Sprite[7];

    public GameObject player;
    public Animator animator;

    // 技能的 parent class 
    Skill skill = new Skill();

    public AudioClip ShieldSound;

    // Start is called before the first frame update
    void Start()
    {
        // Button btn1 = button_1Img.GetComponent<Button>();
        // Button btn2 = button_2Img.GetComponent<Button>();
        // Button btn3 = button_3Img.GetComponent<Button>();

        useSkill1 = PlayerPrefs.GetInt("SkillSlot_1");
        useSkill2 = PlayerPrefs.GetInt("SkillSlot_2");
        useSkill3 = PlayerPrefs.GetInt("SkillSlot_3");

        button_1.GetComponent<Image>().sprite = skillImgs[useSkill1];
        button_2.GetComponent<Image>().sprite = skillImgs[useSkill2];
        button_3.GetComponent<Image>().sprite = skillImgs[useSkill3];

        textCooldown1.gameObject.SetActive(false);
        imageCooldown1.fillAmount = 0;
        textCooldown2.gameObject.SetActive(false);
        imageCooldown2.fillAmount = 0;
        textCooldown3.gameObject.SetActive(false);
        imageCooldown3.fillAmount = 0;
    }
    void Update()
    {
        if (isCooldown1)
        {
            cooldownTimer1 -= Time.deltaTime;
            if (cooldownTimer1 < 0)
            {
                isCooldown1 = false;
                textCooldown1.gameObject.SetActive(false);
                imageCooldown1.fillAmount = 0;
                button_1.interactable = true;
            }
            else
            {
                textCooldown1.text = Mathf.RoundToInt(cooldownTimer1).ToString();
                imageCooldown1.fillAmount = cooldownTimer1 / circleTime1;
                button_1.interactable = false;
            }
        }
        if (isCooldown2)
        {
            cooldownTimer2 -= Time.deltaTime;
            if (cooldownTimer2 < 0)
            {
                isCooldown2 = false;
                textCooldown2.gameObject.SetActive(false);
                imageCooldown2.fillAmount = 0;
                button_2.interactable = true;
            }
            else
            {
                textCooldown2.text = Mathf.RoundToInt(cooldownTimer2).ToString();
                imageCooldown2.fillAmount = cooldownTimer2 / circleTime2;
                button_2.interactable = false;
            }
        }
        if (isCooldown3)
        {
            cooldownTimer3 -= Time.deltaTime;
            if (cooldownTimer3 < 0)
            {
                isCooldown3 = false;
                textCooldown3.gameObject.SetActive(false);
                imageCooldown3.fillAmount = 0;
                button_3.interactable = true;
            }
            else
            {
                textCooldown3.text = Mathf.RoundToInt(cooldownTimer3).ToString();
                imageCooldown3.fillAmount = cooldownTimer3 / circleTime3;
                button_3.interactable = false;
            }
        }
    }

    // 給按鈕用
    public void Slot_1()
    {
        UseSkill(useSkill1);
        isCooldown1 = true;
        textCooldown1.gameObject.SetActive(true);
        cooldownTimer1 = cdTime;
        circleTime1 = cdTime;
    }
    public void Slot_2()
    {
        UseSkill(useSkill2);
        isCooldown2 = true;
        textCooldown2.gameObject.SetActive(true);
        cooldownTimer2 = cdTime;
        circleTime2 = cdTime;
    }
    public void Slot_3()
    {
        UseSkill(useSkill3);
        isCooldown3 = true;
        textCooldown3.gameObject.SetActive(true);
        cooldownTimer3 = cdTime;
        circleTime3 = cdTime;
    }

    // 使用 children class
    void UseSkill(int a)
    {
        if (a == 1)
        {
            Soundmanager.instance.PlaySound(ShieldSound);
            ShieldSkill shieldSkill = new ShieldSkill();
            shieldSkill.Player = player;
            shieldSkill.Player_Anim = animator;
            shieldSkill.ShieldActive();
            cdTime = shieldSkill.cdTime;
        }
        else if (a == 2)
        {
            
            ChainSkill chainSkill = new ChainSkill();
            chainSkill.Player = player;
            chainSkill.Player_Anim = animator;
            chainSkill.ChainActive();
            cdTime = chainSkill.cdTime;
        }
        else if (a == 3)
        {
            HealSkill healSkill = new HealSkill();
            healSkill.Player = player;
            healSkill.Player_Anim = animator;
            healSkill.HealActive();
            cdTime = healSkill.cdTime;
        }
        else if (a == 4)
        {
            AtkBuffSkill atkBuffSkill = new AtkBuffSkill();
            atkBuffSkill.Player = player;
            atkBuffSkill.Player_Anim = animator;
            atkBuffSkill.AtkBuffActive();
            cdTime = atkBuffSkill.cdTime;
        }
        else if (a == 5)
        {
            ClawSkill clawSkill = new ClawSkill();
            clawSkill.Player = player;
            clawSkill.Player_Anim = animator;
            clawSkill.ClawActive();
            cdTime = clawSkill.cdTime;
        }
        else if (a == 6)
        {
            ThunderSkill thunderSkill = new ThunderSkill();
            thunderSkill.Player = player;
            thunderSkill.Player_Anim = animator;
            thunderSkill.ThunderActive();
            cdTime = thunderSkill.cdTime;
        }
        else if (a == 7)
        {
            FlySkill flySkill = new FlySkill();
            flySkill.Player = player;
            flySkill.Player_Anim = animator;
            flySkill.FlyActive();
            cdTime = flySkill.cdTime;
        }
    }
}