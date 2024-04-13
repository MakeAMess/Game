using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    private float rotationspeed = 300;
    [SerializeField]
    private Transform player;

    public float Ysensitivity;
    private float rotationY = 0f;

    private void Update()
    {
        transform.position = player.transform.position;

        if (Input.GetAxis("Mouse Y") != 0 || Input.GetAxis("Mouse X") != 0)
        {
            //float verticalInput = Input.GetAxis("Mouse Y") * rotationspeed * Time.deltaTime;
            float horizontalInput = Input.GetAxis("Mouse X") * rotationspeed * Time.deltaTime;
            //transform.Rotate(Vector3.right, verticalInput);
            transform.Rotate(Vector3.up, horizontalInput);
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0);

            rotationY += Input.GetAxis("Mouse Y") * Ysensitivity;


            rotationY = Mathf.Clamp(rotationY, -15, 15);
            transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, transform.localEulerAngles.z);
        }
    }
}