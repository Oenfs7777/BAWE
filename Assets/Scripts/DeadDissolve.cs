using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadDissolve : MonoBehaviour
{
    public GameObject deadDissolve;

    public float alphaSpeed;

    private bool isDissolve;

    private SpriteRenderer spriteRenderer;

    private float alpha = 1;


    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        deadDissolve.SetActive(false);
    }

    private void Update()
    {
        if (isDissolve)
        {
            alpha -= alphaSpeed * Time.deltaTime;
            spriteRenderer.color = new Color(1, 1, 1, alpha);

            if (alpha <= 0.25f && !deadDissolve.activeSelf)
            {
                deadDissolve.SetActive(true);
            }
            if (alpha <= 0)
            {
                isDissolve = false;
                gameObject.SetActive(false);
            }
        }
    }

    void DeadDisslove()
    {
        isDissolve = true;
    }
}

