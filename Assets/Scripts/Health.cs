using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;

    private Animator SA;
    public void TakeDamage(int damage)
    {
        health -= damage;
       
        if (health <=0)
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
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(5);
        }
    }
   
}
