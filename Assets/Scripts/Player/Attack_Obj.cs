using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_Obj : MonoBehaviour
{
    // 攻擊速度
    public float Speed = 50;
    public Rigidbody2D rb;
    public GameObject DL, DR, UL, UR;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector3(2.2f, 1, 0) * Speed;
    }
}