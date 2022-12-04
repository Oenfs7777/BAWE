using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillSelectTest : MonoBehaviour
{
    public int[] skill = new int[6];

    public int skill1, skill2, skill3;

    public int a;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteAll();
    }

    // Update is called once per frame
    void Update()
    {
        SelectTest();
        if (Input.GetKeyDown(KeyCode.I))
        {
            skill1 = SelectTest();
            PlayerPrefs.SetInt("SkillSlot_1", skill1);
            Debug.Log("Skill" + skill1 + "in Slot_1");
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            skill2 = SelectTest();
            PlayerPrefs.SetInt("SkillSlot_2", skill2);
            Debug.Log("Skill" + skill2 + "in Slot_2");
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            skill3 = SelectTest();
            PlayerPrefs.SetInt("SkillSlot_3", skill3);
            Debug.Log("Skill" + skill3 + "in Slot_3");
        }
    }
    private int SelectTest()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            a = 1;
            Debug.Log("Skill1_Selected");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            a = 2;
            Debug.Log("Skill2_Selected");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            a = 3;
            Debug.Log("Skill3_Selected");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            a = 4;
            Debug.Log("Skill4_Selected");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            a = 5;
            Debug.Log("Skill5_Selected");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            a = 6;
            Debug.Log("Skill6_Selected");
        }
        return a;
    }
}
