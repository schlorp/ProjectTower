using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private int speed = 10;
    [SerializeField] private GroundCheck groundcheck;

    void Start()
    {
        rb = gameObject.GetComponentInChildren<Rigidbody2D>();
        groundcheck = gameObject.GetComponentInChildren<GroundCheck>();

    }

    void Update()
    {
        //up to change (new unity input system)
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
        }


        //up to change (maybe use own gravity)
        if (Input.GetKey(KeyCode.Space) && groundcheck.canjump)
        {
            rb.velocity = new Vector3(0, 10, 0);
        }
    }
}
