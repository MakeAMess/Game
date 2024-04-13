using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    private float rotationspeed = 300;
    [SerializeField]
    private Transform player;
    [SerializeField] Vector3 offset = new Vector3(0,1,0);

    public float Ysensitivity;
    private float rotationY = 0f;

    private void Update()
    {
        transform.position = player.transform.position + offset;

        if (Input.GetAxis("Mouse Y") != 0 || Input.GetAxis("Mouse X") != 0)
        {
            float horizontalInput = Input.GetAxis("Mouse X") * rotationspeed * Time.deltaTime;
            transform.Rotate(Vector3.up, horizontalInput);
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, 0);

            rotationY += Input.GetAxis("Mouse Y") * Ysensitivity;


            rotationY = Mathf.Clamp(rotationY, -30, 30);
            transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, transform.localEulerAngles.z);
        }
    }
}