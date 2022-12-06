using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerHealth : MonoBehaviour
{
    public int health;

    private Animator PA;

    public GameObject deadButton;
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            health = 0;

            Debug.Log("Dead!");

            PA.SetTrigger("IsDead");
            Invoke("Dead", 2.5f);
        }
        PlayerHealthBar.HealthCurrent = health;
    }
    void Start()
    {
        PlayerHealthBar.HealthMax = health;
        PlayerHealthBar.HealthCurrent = health;

        PA = gameObject.GetComponent<Animator>();
    }
    void Dead()
    {
        deadButton.SetActive(true);
    }
}
