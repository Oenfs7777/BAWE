using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bigshotbutton : MonoBehaviour
{
    int clickedCount = 0;
    private Button clicked1, clicked2;
    private Vector3 position1, position2;
    

    private void FixedUpdate()
    {
        if (clickedCount == 2)
        {
            clicked1.transform.position = Vector3.Lerp(clicked1.transform.position, position2, 10f);
            clicked2.transform.position = Vector3.Lerp(clicked2.transform.position, position1, 10f);
            Invoke("FirstScale", .3f);
        }

    }

    private void FirstScale()
    {
        clicked1.transform.name = "btn2";
        clicked2.transform.name = "btn2";

        clicked1.transform.localScale = new Vector2(1f, 1f);
        clicked2.transform.localScale = new Vector2(1f, 1f);
        clickedCount = 0;
    }
    public void forBtn(Button btn)
    {

        if (btn.transform.name != "clicked" && clickedCount == 0)
        {
            clicked1 = btn;
            position1 = btn.transform.position;
            btn.transform.name = "clicked";
            btn.transform.localScale = new Vector2(1.2f, 1.2f);
            clickedCount++;
        }
        else if (btn.transform.name != "clicked" && clickedCount == 1)
        {
            clicked2 = btn;
            position2 = btn.transform.position;
            btn.transform.name = "clicked";
            btn.transform.localScale = new Vector2(1.2f, 1.2f);
            clickedCount++;
        }


    }
}
