using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_Effect : MonoBehaviour
{
    public GameObject Shield;
    public GameObject Player;

    public void CreateShield()
    {
        Instantiate(Shield, Player.transform);
    }
}