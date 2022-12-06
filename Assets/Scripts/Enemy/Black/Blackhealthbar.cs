using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blackhealthbar : MonoBehaviour
{
    public Text healthText;
    public static int HealthCurrent;
    public static int HealthMax;
    private Image BlackhealthBar;



    // Start is called before the first frame update
    void Start()
    {
        BlackhealthBar = GetComponent<Image>();
        //HealthCurrent = HealthMax;


    }

    // Update is called once per frame
    void Update()
    {
        BlackhealthBar.fillAmount = (float)HealthCurrent / (float)HealthMax;
        healthText.text = HealthCurrent.ToString() + "/" + HealthMax.ToString();
    }


}
