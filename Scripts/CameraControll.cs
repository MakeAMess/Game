using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    private float rotationspeed = 100;
    [SerializeField]
    private Transform player;

    private void Update()
    {
        transform.position = player.transform.position;

        if (Input.GetAxis("Mouse Y") != 0 || Input.GetAxis("Mouse X") != 0)
        {
            float verticalInput = Input.GetAxis("Mouse Y") * rotationspeed * Time.deltaTime;
            float horizontalInput = Input.GetAxis("Mouse X") * rotationspeed * Time.deltaTime;
            transform.Rotate(Vector3.right, verticalInput);
            transform.Rotate(Vector3.up, horizontalInput);
            transform.eulerAngles = new Vector3(Mathf.Clamp(transform.eulerAngles.x, 10, 60), transform.eulerAngles.y, 0);
        }
    }
}