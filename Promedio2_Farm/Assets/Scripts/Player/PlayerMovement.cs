using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform orientation;

    private Vector3 dir;

    private Rigidbody rb;

    private Vector2 inputMove;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        // vertical = y
        dir = orientation.forward * inputMove.y + orientation.right * inputMove.x;

        rb.AddForce(dir.normalized * speed, ForceMode.Force);
    }

    public void InputMove(InputAction.CallbackContext context)
    {
         inputMove = context.ReadValue<Vector2>();
    }
}
