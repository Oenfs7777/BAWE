using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombEX : MonoBehaviour
{

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Over"))
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerHealth player = collision.GetComponent<PlayerHealth>();
        if (collision.tag=="Monster"|| collision.tag == "Player")
        {
            player.TakeDamage(25);
        }
    }
}

