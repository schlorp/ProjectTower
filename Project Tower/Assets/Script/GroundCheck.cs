using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool canjump;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            canjump = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        canjump = false;
    }
}
