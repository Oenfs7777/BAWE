using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_Button : MonoBehaviour
{
    public GameObject Player;
    public Animator Player_Anim;

    private void Start()
    {

    }

    public void Skill1()
    {
        Player_Anim.SetTrigger("IsShield");
    }

    public void skill()
    {
        Debug.Log("test");
    }
}
