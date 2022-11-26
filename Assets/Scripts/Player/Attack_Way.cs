using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_Way : Player
{
    protected float x = 2.2f, y = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PosUL)
        {
            x = 0;
            y = 0;
        }
    }
}
