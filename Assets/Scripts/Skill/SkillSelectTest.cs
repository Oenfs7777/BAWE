using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillSelectTest : MonoBehaviour
{
    public int skill1, skill2, skill3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            skill1 = 1;
            PlayerPrefs.SetInt("Skill1", skill1);
            Debug.Log("Skill1_Selected");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            skill2 = 2;
            PlayerPrefs.SetInt("Skill2", skill2);
            Debug.Log("Skill2_Selected");

        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            skill3 = 3;
            PlayerPrefs.SetInt("Skill3", skill3);
            Debug.Log("Skill3_Selected");
        }
    }
}
