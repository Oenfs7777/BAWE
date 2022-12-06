using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axehealth : MonoBehaviour
{
    public int health;

    

    // ����ˮ`
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            health = 0;

            Debug.Log("Dead!");

            
        }
        Axehealthbar.HealthCurrent = health;
    }
    void Start()
    {

        
        Axehealthbar.HealthMax = health;
        Axehealthbar.HealthCurrent = health;

        
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
}

