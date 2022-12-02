using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkillTest : MonoBehaviour
{
    int skill1, skill2, skill3;
    Skill skill = new Skill();
    // Start is called before the first frame update
    void Start()
    {
        skill1 = PlayerPrefs.GetInt("Skill1");
        skill2 = PlayerPrefs.GetInt("Skill2");
        skill3 = PlayerPrefs.GetInt("Skill3");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            skill.UseSkill(skill1);
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            skill.UseSkill(skill2);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            skill.UseSkill(skill3);
        }
    }
}