using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cloud_anim : MonoBehaviour
{
    public float speed = 0;
    float pos = 0;
    private RawImage image;

    void Start()
    {
        image = GetComponent<RawImage>();
    }

    void Update()
    {
        pos += speed;

        if (pos > 1F)

            pos -= 1F;

        image.uvRect = new Rect(pos, 0, 1, 1);
    }
}
