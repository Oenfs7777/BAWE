using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
    public static int HealthCurrent;
    public static int HealthMax;
    private Image PHealthBar;



    // Start is called before the first frame update
    void Start()
    {
        PHealthBar = GetComponent<Image>();
        //HealthCurrent = HealthMax;


    }

    // Update is called once per frame
    void Update()
    {
        PHealthBar.fillAmount = (float)HealthCurrent / (float)HealthMax;
    }
}
