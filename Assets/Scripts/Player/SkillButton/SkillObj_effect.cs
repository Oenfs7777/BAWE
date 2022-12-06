using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillObj_effect : MonoBehaviour
{
    //public GameObject Shield;
    //public GameObject ChianEffect;
    public GameObject Tcall;
    public Rigidbody2D RB;
    public float CallSpeed = 0.5f;

    private void Start()
    {

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Destroy(GameObject.Find("Shield(Clone)"), 10f);
        Destroy(GameObject.Find("Chian_Effect(Clone)"),2f);
        TcallEffect();
    }

    public void TcallEffect()
    {
        Tcall.transform.position += new Vector3(0, CallSpeed, 0);
        Destroy(GameObject.Find("Tball(Clone)"), 2f);
    }
}
