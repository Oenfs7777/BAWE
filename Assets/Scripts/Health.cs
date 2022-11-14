using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
    public void TakeDamage(int damage)
    {
        health -= damage;
       
        if (health <=0)
        {
            health = 0;
           
            Debug.Log("Dead!");
        }
        Healthbar.HealthCurrent = health;
    }
    void Start()
    {
        Healthbar.HealthMax = health;
        Healthbar.HealthCurrent = health;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(5);
        }
    }
}
