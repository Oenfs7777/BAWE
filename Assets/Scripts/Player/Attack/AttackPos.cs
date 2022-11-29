using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPos : Player
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Platform")
        {
            AtkBool = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Platform")
        {
            AtkBool = false;
        }
    }
}
