using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float moveSpeed = 20f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveForward = Input.GetAxis("Vertical") * moveSpeed;
        float moveSide = Input.GetAxis("Horizontal") * moveSpeed;

        Vector3 move = transform.right * moveSide + transform.forward * moveForward;

        rb.MovePosition(rb.position + move * Time.fixedDeltaTime);
    }
}
