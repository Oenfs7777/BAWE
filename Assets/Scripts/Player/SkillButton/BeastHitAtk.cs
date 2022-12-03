using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeastHitAtk : MonoBehaviour
{
    public int damage = 10;

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
        SlimeHealth slime = hitInfo.GetComponent<SlimeHealth>();
        if (slime != null && hitInfo.tag == "Monster")
        {
            slime.TakeDamage(damage);
        }

        Destroy(gameObject, 1f);
    }
}
