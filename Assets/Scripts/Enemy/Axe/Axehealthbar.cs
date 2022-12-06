using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Axehealthbar : MonoBehaviour
{
    public Text healthText;
    public static int HealthCurrent;
    public static int HealthMax;
    private Image AxehealthBar;



    // Start is called before the first frame update
    void Start()
    {
        AxehealthBar = GetComponent<Image>();
        //HealthCurrent = HealthMax;


    }

    // Update is called once per frame
    void Update()
    {
        AxehealthBar.fillAmount = (float)HealthCurrent / (float)HealthMax;
        healthText.text = HealthCurrent.ToString() + "/" + HealthMax.ToString();
    }


}
