using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start()
    {
        rb = gameObject.GetComponentInChildren<Rigidbody2D>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {

        }
    }
}
