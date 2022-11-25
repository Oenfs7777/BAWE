using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadDissolve : MonoBehaviour
{
    public GameObject deadDisslove;

    public float alphaSpeed;

    private bool isDisslove;

    private SpriteRenderer spriteRenderer;

    private float alpha = 1;


    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        deadDisslove.SetActive(false);
    }

    private void Update()
    {
        if (isDisslove)
        {
            alpha -= alphaSpeed * Time.deltaTime;
            spriteRenderer.color = new Color(1, 1, 1, alpha);

            if (alpha <= 0.25f && !deadDisslove.activeSelf)
            {
                deadDisslove.SetActive(true);
            }
            if (alpha <= 0)
            {
                isDisslove = false;
                gameObject.SetActive(false);
            }
        }
    }    

        void DeadDisslove()
        {
            isDisslove = true;
        }
    }

