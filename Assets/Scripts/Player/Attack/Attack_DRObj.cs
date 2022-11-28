using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Attack_DRObj : MonoBehaviour
{
    // 攻擊速度
    public float AttackSpeed = 10;
    public Rigidbody2D rb;
    //public GameObject DL, DR, UL, UR;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector3(-2, 1, 0) * AttackSpeed;
    }
}