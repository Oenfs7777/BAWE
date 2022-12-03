using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_Effect : MonoBehaviour
{
    public GameObject ShieldObj;
    public GameObject Player;
    public GameObject TcallObj;
    public GameObject ThunderObj;
    public GameObject BeastHitObj;
    public Transform AttackPoint;
    public Transform SkyPoint;
    public Transform BPoint;

    public int UpAtkTime=8;

    public void FixedUpdate()
    {
        
    }
    public void CreateShield()
    {
        Instantiate(ShieldObj, Player.transform);
    }

    public void Tcall()
    {
        Instantiate(TcallObj, AttackPoint.position, AttackPoint.rotation);
    }

    public void Thunder()
    {
        Instantiate(ThunderObj, SkyPoint.position, SkyPoint.rotation);
    }

    public void BHit()
    {
        Instantiate(BeastHitObj, BPoint.position, BPoint.rotation);
    }
}
