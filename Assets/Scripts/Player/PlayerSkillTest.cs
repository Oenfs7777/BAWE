using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkillTest : MonoBehaviour
{
    int useSkill1, useSkill2, useSkill3;
    Skill skill = new Skill();
    // Start is called before the first frame update
    void Start()
    {
        useSkill1 = PlayerPrefs.GetInt("SkillSlot_1");
        useSkill2 = PlayerPrefs.GetInt("SkillSlot_2");
        useSkill3 = PlayerPrefs.GetInt("SkillSlot_3");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            skill.UseSkill(useSkill1);
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            skill.UseSkill(useSkill2);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            skill.UseSkill(useSkill3);
        }
    }
}