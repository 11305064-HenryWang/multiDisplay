using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotateScript : MonoBehaviour
{
    private float x;
    private float y;
    public float sensitivity = -1f;
    private Vector3 rotate;
    // public float speed = 1f;
    // public float radius = 5f; // Adjustable radius
    // public Vector3 targetPosition = Vector3.zero; // The point the camera orbits around

    // public float angle = 0f; // Angle to rotate around the target point

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        y = Input.GetAxis("Mouse X");
        // x = Input.GetAxis("Mouse Y");
        x = 0;
        rotate = new Vector3(x, y * sensitivity, 0);
        transform.eulerAngles = transform.eulerAngles - rotate;
    }
    // void Update()
    // {
    //     angle += Input.GetAxis("Mouse X") * speed;
    //     float x = targetPosition.x +  Mathf.Cos(angle) * radius;
    //     float y = targetPosition.y;
    //     float z = targetPosition.z + Mathf.Sin(angle) * radius;

    //     transform.position = new Vector3(x, y, z);

    //     // angle += Time.deltaTime * speed;
    // }

}
