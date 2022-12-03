using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderAtk : MonoBehaviour
{
    public int damage = 10;
    public GameObject hitEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Health slime = hitInfo.GetComponent<Health>();
        if (slime != null && hitInfo.tag == "Monster")
        {
            slime.TakeDamage(damage);
        }
        Instantiate(hitEffect, slime.transform.position, hitEffect.transform.rotation);

        Destroy(gameObject, 0.3f);
    }
}
