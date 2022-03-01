using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]private int speed = 10;

    void Start()
    {
        rb = gameObject.GetComponentInChildren<Rigidbody2D>();
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity += new Vector2(-speed,0) * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            rb.velocity += new Vector2(speed * 10, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity += new Vector2(speed, 0) * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            rb.velocity += new Vector2(-speed * 10, 0) * Time.deltaTime;
        }
    }
}
