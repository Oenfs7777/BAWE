using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class SlimeHealthbar : MonoBehaviour
{
    public Text healthText;
    public static int HealthCurrent;
    public static int HealthMax;
    private Image SlimehealthBar;
    
   

    // Start is called before the first frame update
    void Start()
    {
        SlimehealthBar = GetComponent<Image>();
        //HealthCurrent = HealthMax;


    }

    // Update is called once per frame
    void Update()
    {
        SlimehealthBar.fillAmount = (float)HealthCurrent / (float)HealthMax;
        healthText.text = HealthCurrent.ToString() + "/" + HealthMax.ToString();
    }
   
    
}
