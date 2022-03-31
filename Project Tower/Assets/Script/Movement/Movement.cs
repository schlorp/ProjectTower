using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private PlayerInputActions playerinput;
    private InputAction move;
    private Vector2 movedirection;

    public Rigidbody2D rb;

    public float movespeed;

    private void Awake()
    {
        playerinput = new PlayerInputActions();
    }

    private void OnEnable()
    {
        move = playerinput.Player.Move;
        move.Enable();
    }
    private void OnDisable()
    {
        move.Disable();
    }

    void Update()
    {
        movedirection = move.ReadValue<Vector2>();

        rb.velocity = new Vector2(movedirection.x * movespeed, 0);
    }
}
