using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;


    private float speed = 5;
    private float rotationSpeed = 2;
    private float jumpHeight = 6;

    private bool grounded;
    [SerializeField] LayerMask groundLayer;

    [SerializeField] Transform cameraTransform;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        grounded = Physics.Raycast(transform.position, Vector3.down, 1.01f, groundLayer);

        Move(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));

        if (Input.GetButtonDown("Jump"))
            Jump();
    }

    public void Move(Vector2 movement)
    {
        {
            Vector3 firstMoveVector = transform.forward * movement.y * speed * Time.deltaTime;
            Vector3 secondMoveVector = transform.right * movement.x * speed * Time.deltaTime;
            Vector3 moveVector = firstMoveVector + secondMoveVector;
            rb.MovePosition(rb.position + moveVector);

            //handles rotation
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(cameraTransform.forward), Time.deltaTime * rotationSpeed);
            transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y, 0);
        }
    }

    public void Jump()
    {
        if (grounded == true)
            rb.velocity = new Vector3(rb.velocity.x, jumpHeight, rb.velocity.z);
    }
}