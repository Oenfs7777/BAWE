using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkillTest : MonoBehaviour
{
    int a = 0;
    Skill skill = new Skill();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            a = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            a = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            a = 3;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            a = 4;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            a = 5;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            a = 6;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            a = 7;
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            skill.UseSkill(a);
        }
    }
}