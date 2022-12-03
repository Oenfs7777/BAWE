using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D RB;
    public Transform Target;
    public float speed;
    public int damage = 10;

    private float MaxLifetime = 5.0f;
    private float lifeTime;

    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Target.position, speed * Time.deltaTime);
        lifeTime += Time.deltaTime;
        if (lifeTime > MaxLifetime)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerHealth player = collision.GetComponent<PlayerHealth>();
        if (collision.tag== "Player")
        {
            player.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
