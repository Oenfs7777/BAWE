using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SF : MonoBehaviour
{
    public Rigidbody2D RB;
    public Transform DL, DR, UL, UR;
    public Player GetPlayer;
    public float speed;

    private float MaxLifetime = 5.0f;
    private float lifeTime;
    // Start is called before the first frame update
    void Start()
    {
        DL = GameObject.Find("DL").GetComponent<Transform>();
        UL = GameObject.Find("UL").GetComponent<Transform>();
        DR = GameObject.Find("DR").GetComponent<Transform>();
        UR = GameObject.Find("UR").GetComponent<Transform>();
        GetPlayer = GameObject.Find("Player").GetComponent<Player>();

        PlayerWhere();
    }

    // Update is called once per frame
    void Update()
    {
        lifeTime += Time.deltaTime;
        if (lifeTime > MaxLifetime)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerHealth player = other.GetComponent<PlayerHealth>();
        if (other.tag == "Player")
        {
            player.TakeDamage(5);
            Destroy(gameObject);
        }
    }

    public void PlayerWhere()
    {

        if (GetPlayer.currentPos == Pos.DL)
        {
            RB.velocity = new Vector3(2, 1, 0) * -speed;
            transform.Rotate(0, 0, -15);
        }
        else if (GetPlayer.currentPos == Pos.UL)
        {
            RB.velocity = new Vector3(-3f, 1, 0) * speed;
        }
        else if (GetPlayer.currentPos == Pos.DR)
        {
            RB.velocity = new Vector3(-2, 1, 0) * -speed;
        }
        else if (GetPlayer.currentPos == Pos.UR)
        {
            RB.velocity = new Vector3(3f, 1, 0) * speed;
        }

    }
}
