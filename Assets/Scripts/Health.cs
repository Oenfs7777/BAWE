using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;

    private Animator SA;

    // 受到傷害
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            health = 0;

            Debug.Log("Dead!");

            SA.SetTrigger("SlimeDead");
        }
        Healthbar.HealthCurrent = health;
    }
    void Start()
    {
        Healthbar.HealthMax = health;
        Healthbar.HealthCurrent = health;

        SA = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(5);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" || collision.tag == "Attack")
        {
            TakeDamage(5);
            Debug.Log("HIT!!");
        }
    }
}
