using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillObj_effect : MonoBehaviour
{
    //public GameObject Shield;
    //public GameObject ChianEffect;
    public GameObject Tcall;

    public float CallSpeed = 0.5f;


    // Update is called once per frame
    void FixedUpdate()
    {
        Destroy(GameObject.Find("Shield(Clone)"), 3f);
        Destroy(GameObject.Find("Chian_Effect(Clone)"),3f);
        TcallEffect();
    }

    public void TcallEffect()
    {
        Tcall.transform.position += new Vector3(0, CallSpeed, 0);
        Destroy(GameObject.Find("Tball(Clone)"), 2f);
    }
}
