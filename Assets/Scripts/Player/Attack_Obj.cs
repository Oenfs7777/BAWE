using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Attack_Obj : MonoBehaviour
{
    // 參考 Player
    public Player player;

    // 攻擊速度
    public float speed = 10;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        if (player.currentPos == Pos.UL)
        {
            rb.velocity = new Vector3(-2, 1, 0) * -speed;
        }
        else if (player.currentPos == Pos.UR)
        {
            rb.velocity = new Vector3(2, 1, 0) * -speed;
        }
        else if (player.currentPos == Pos.DL)
        {
            rb.velocity = new Vector3(2, 1, 0) * speed;
        }
        else if (player.currentPos == Pos.DR)
        {
            rb.velocity = new Vector3(-2, 1, 0) * speed;
        }

    }
}