using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillSelect : MonoBehaviour
{
    // public int[] skill = new int[6];
    public Sprite[] skillImgs = new Sprite[7];

    public GameObject button_1Img, button_2Img, button_3Img;

    public int skillNum;

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
        skillNum = 5;
        Debug.Log("Skill5_Selected");
    }
    public void SelectSkill_6()
    {
        skillNum = 6;
        Debug.Log("Skill6_Selected");
    }

    public void SkillSlot_1Confirm()
    {
        PlayerPrefs.SetInt("SkillSlot_1", skillNum);
        Button btn1 = button_1Img.GetComponent<Button>();
        btn1.GetComponent<Image>().sprite = skillImgs[skillNum];
        Debug.Log("Skill" + skillNum + "in Slot_1");
    }
    public void SkillSlot_2Confirm()
    {
        PlayerPrefs.SetInt("SkillSlot_2", skillNum);
        Button btn2 = button_2Img.GetComponent<Button>();
        btn2.GetComponent<Image>().sprite = skillImgs[skillNum];
        Debug.Log("Skill" + skillNum + "in Slot_2");
    }
    public void SkillSlot_3Confirm()
    {
        PlayerPrefs.SetInt("SkillSlot_3", skillNum);
        Button btn3 = button_3Img.GetComponent<Button>();
        btn3.GetComponent<Image>().sprite = skillImgs[skillNum];
        Debug.Log("Skill" + skillNum + "in Slot_3");
    }
    // Update is called once per frame
    void Update()
    {
        // SelectTest();
        // if (Input.GetKeyDown(KeyCode.I))
        // {
        //     skill1 = SelectTest();
        //     PlayerPrefs.SetInt("SkillSlot_1", skill1);
        //     Debug.Log("Skill" + skill1 + "in Slot_1");
        // }
        // if (Input.GetKeyDown(KeyCode.O))
        // {
        //     skill2 = SelectTest();
        //     PlayerPrefs.SetInt("SkillSlot_2", skill2);
        //     Debug.Log("Skill" + skill2 + "in Slot_2");
        // }
        // if (Input.GetKeyDown(KeyCode.P))
        // {
        //     skill3 = SelectTest();
        //     PlayerPrefs.SetInt("SkillSlot_3", skill3);
        //     Debug.Log("Skill" + skill3 + "in Slot_3");
        // }
    }

    private int SelectTest()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            skillNum = 1;
            Debug.Log("Skill1_Selected");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            skillNum = 2;
            Debug.Log("Skill2_Selected");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            skillNum = 3;
            Debug.Log("Skill3_Selected");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            skillNum = 4;
            Debug.Log("Skill4_Selected");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            skillNum = 5;
            Debug.Log("Skill5_Selected");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            skillNum = 6;
            Debug.Log("Skill6_Selected");
        }
        return skillNum;
    }
}
