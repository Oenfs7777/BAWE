using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderAtk : MonoBehaviour
{
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
        if (hitInfo.tag == "Monster")
        {
            Instantiate(hitEffect, hitInfo.transform.position, hitEffect.transform.rotation);
        }
        Destroy(gameObject, 0.3f);
    }
}
