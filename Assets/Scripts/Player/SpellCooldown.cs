using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpellCooldown : MonoBehaviour
{
    [SerializeField]
    private Image imageCooldown;
    [SerializeField]
    private TMP_Text textCooldown;
    

    private bool isCooldown = false;
    public float cooldownTime = 10.0f;
    private float cooldownTimer = 0.0f;
    public KeyCode spell1;
    void Start()
    {
        textCooldown.gameObject.SetActive(false);
        imageCooldown.fillAmount = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(spell1))
        {
            UseSpell();
        }
        if(isCooldown)
        {
            ApplyCooldown();
        }
    }

    void ApplyCooldown()
    {
        cooldownTimer -= Time.deltaTime;
        if(cooldownTimer < 0.0f)
        {
            isCooldown = false;
            textCooldown.gameObject.SetActive(false);
            imageCooldown.fillAmount = 0.0f;
        }
        else
        {
            textCooldown.text = Mathf.RoundToInt(cooldownTimer).ToString();
            imageCooldown.fillAmount = cooldownTimer / cooldownTime;
        }
    }
    public void UseSpell()
    {
        if(isCooldown)
        {
            //return false;
        }
        else
        {
            isCooldown = true;
            textCooldown.gameObject.SetActive(true);
            cooldownTimer = cooldownTime;
            //return true;
        }
    }
}
