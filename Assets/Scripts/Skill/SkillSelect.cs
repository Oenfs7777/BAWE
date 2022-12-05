using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillSelect : MonoBehaviour
{
    // public int[] skill = new int[6];
    public Sprite[] skillImgs = new Sprite[7];

    public GameObject button_1Img, button_2Img, button_3Img;

    public int skillSelectNum1, skillSelectNum2;

    public int skillNum, skillBigNum;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteAll();
    }
    public void SelectSkill_1()
    {
        skillNum = 1;
        Debug.Log("Skill1_Selected");
    }
    public void SelectSkill_2()
    {
        skillNum = 2;
        Debug.Log("Skill2_Selected");
    }
    public void SelectSkill_3()
    {
        skillNum = 3;
        Debug.Log("Skill3_Selected");
    }
    public void SelectSkill_4()
    {
        skillNum = 4;
        Debug.Log("Skill4_Selected");
    }
    public void SelectSkill_5()
    {
        skillBigNum = 5;
        Debug.Log("Skill5_Selected");
    }
    public void SelectSkill_6()
    {
        skillBigNum = 6;
        Debug.Log("Skill6_Selected");
    }

    public void SkillSlot_1Confirm()
    {
        skillSelectNum1 = skillNum;
        if (skillSelectNum1 != skillSelectNum2)
        {
            PlayerPrefs.SetInt("SkillSlot_1", skillSelectNum1);
            Button btn1 = button_1Img.GetComponent<Button>();
            btn1.GetComponent<Image>().sprite = skillImgs[skillSelectNum1];
            Debug.Log("Skill" + skillSelectNum1 + "in Slot_1");
        }
    }
    public void SkillSlot_2Confirm()
    {
        skillSelectNum2 = skillNum;
        if (skillSelectNum1 != skillSelectNum2)
        {
            PlayerPrefs.SetInt("SkillSlot_2", skillSelectNum2);
            Button btn2 = button_2Img.GetComponent<Button>();
            btn2.GetComponent<Image>().sprite = skillImgs[skillSelectNum2];
            Debug.Log("Skill" + skillSelectNum2 + "in Slot_2");
        }
    }
    public void SkillSlot_3Confirm()
    {
        PlayerPrefs.SetInt("SkillSlot_3", skillBigNum);
        Button btn3 = button_3Img.GetComponent<Button>();
        btn3.GetComponent<Image>().sprite = skillImgs[skillBigNum];
        Debug.Log("Skill" + skillBigNum + "in Slot_3");
    }
}
