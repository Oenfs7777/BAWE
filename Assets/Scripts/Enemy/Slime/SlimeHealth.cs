using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SlimeHealth : MonoBehaviour
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

            // 死亡後三秒切換場景
            Invoke("Dead", 3.0f);
        }
        SlimeHealthbar.HealthCurrent = health;
    }
    void Start()
    {
        SlimeHealthbar.HealthMax = health;
        SlimeHealthbar.HealthCurrent = health;

        SA = gameObject.GetComponent<Animator>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PsycalAttack")
        {
            TakeDamage(10);
            Debug.Log("HIT!!");
        }
        else if (collision.tag == "BuffAtk")
        {
            TakeDamage(15);
        }
        else if (collision.tag == "Chian")
        {
            TakeDamage(3);
        }
        else if (collision.tag == "Thunder")
        {
            TakeDamage(30);
        }
        else if (collision.tag == "BeastHit")
        {
            TakeDamage(30);
        }
    }

    // 切換場景
    void Dead()
    {
        SceneManager.LoadScene("SkillScene01");
    }
}
