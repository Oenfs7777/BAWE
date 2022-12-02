using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shieldeffect : MonoBehaviour
{
    public GameObject Shield;
    public GameObject ChianEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Destroy(Shield, 3f);
        Destroy(ChianEffect, 3f);
    }
}
