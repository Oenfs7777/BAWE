using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Guardhealthbar : MonoBehaviour
{
    public Text healthText;
    public static int HealthCurrent;
    public static int HealthMax;
    private Image GuardhealthBar;



    // Start is called before the first frame update
    void Start()
    {
        GuardhealthBar = GetComponent<Image>();
        //HealthCurrent = HealthMax;


    }

    // Update is called once per frame
    void Update()
    {
        GuardhealthBar.fillAmount = (float)HealthCurrent / (float)HealthMax;
        healthText.text = HealthCurrent.ToString() + "/" + HealthMax.ToString();
    }


}
