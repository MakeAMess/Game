using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;

    private float speed = 2;
    private int rotationSpeed = 240;

    private bool grounded;
    [SerializeField] LayerMask groundLayer;

    [SerializeField] Transform cameraTransform;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
    }

    public void Move(Vector2 movement)
    {
        {
            //Walking forward and backwards
            Vector3 moveVector = transform.forward * movement.y * speed * Time.deltaTime;
            rb.MovePosition(rb.position + moveVector);

            //handles rotation
            transform.Rotate(Vector3.up * movement.x * rotationSpeed * Time.deltaTime);
        }
    }
}
