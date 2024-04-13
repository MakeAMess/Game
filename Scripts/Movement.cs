
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;

    private float speed = 2;

    private bool grounded;
    [SerializeField] LayerMask groundLayer;

    [SerializeField] Transform cameraTransform;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
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
            //Walking forward and backwards
            Vector3 moveVector = transform.forward * (movement.y * speed * Time.deltaTime);
            rb.MovePosition(rb.position + moveVector);

            //handles rotation
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(cameraTransform.forward), Time.deltaTime);
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
        }
    }

    public void Jump()
    {
        if (grounded == true)
            rb.velocity = new Vector3(rb.velocity.x, 3, rb.velocity.z);
    }
}