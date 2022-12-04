using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Detail2 : MonoBehaviour
{
    public Text skillNameText;
    public Text skillDesText;
    public Image skillImage;

    public int skillButtonID; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PressSkillButton()
    {
        skillImage.sprite = Skillmanager.instance.skills[skillButtonID].skillSprite;
        skillNameText.text = Skillmanager.instance.skills[skillButtonID].skillName;
        skillDesText.text = Skillmanager.instance.skills[skillButtonID].skillDes;
    }
    
}
