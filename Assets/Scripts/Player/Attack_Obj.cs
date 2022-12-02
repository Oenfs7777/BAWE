using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Attack_Obj : MonoBehaviour
{
    // 參考 Player
    public Player player;

    public int damage = 10;

    public GameObject hitEffect;

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
        Invoke("DestoryGameObj", 3);
    }
    void DestoryGameObj()
    {
        Destroy(gameObject);
    }

    void DestoryHit()
    {
        Destroy(hitEffect);
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Health slime =  hitInfo.GetComponent<Health>();
        if(slime != null && hitInfo.tag == "Monster")
        {
            slime.TakeDamage(damage);
        }
        Instantiate(hitEffect, slime.transform.position, hitEffect.transform.rotation);

        Destroy(gameObject);
    }
}