using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Guardhealth : MonoBehaviour
{
    public int health;



    // 受到傷害
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            health = 0;
            Dead();
            Debug.Log("Dead!");
        }
        Guardhealthbar.HealthCurrent = health;
    }
    void Start()
    {


        Guardhealthbar.HealthMax = health;
        Guardhealthbar.HealthCurrent = health;


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
        SceneManager.LoadScene("SkillScene02");
    }
}


