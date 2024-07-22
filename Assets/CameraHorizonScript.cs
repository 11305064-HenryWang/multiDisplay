using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHorizonScript : MonoBehaviour
{
    private float x;
    private float y;
    public float sensitivity = 100.0f;
    private Vector3 rotate;

    // Start is called before the first frame update
    void Start()
    {
        // Cursor.lockState = CursorLockMode.Locked;
        Cursor.lockState = CursorLockMode.None; // This unlocks the cursor
        Cursor.visible = true; // This makes the cursor visible 
    }

    // Update is called once per frame
    // void Update()
    // {
    //     y = Input.GetAxis("Mouse X");
    //     x = Input.GetAxis("Mouse Y");
    //     rotate = new Vector3(x, y * sensitivity, 0);
    //     transform.eulerAngles = transform.eulerAngles - rotate;
    // }
    void Update()
{
    // Existing rotation code
    // y = Input.GetAxis("Mouse X");
    // x = Input.GetAxis("Mouse Y");
    // rotate = new Vector3(x, y * sensitivity, 0);
    // transform.eulerAngles = transform.eulerAngles - rotate;

    // New position code
    Vector3 move = new Vector3();
    if (Input.GetKey(KeyCode.UpArrow))
    {
        move += transform.forward;
    }
    if (Input.GetKey(KeyCode.DownArrow))
    {
        move -= transform.forward;
    }
    if (Input.GetKey(KeyCode.LeftArrow))
    {
        move -= transform.right;
    }
    if (Input.GetKey(KeyCode.RightArrow))
    {
        move += transform.right;
    }

    transform.position += move * Time.deltaTime * sensitivity;
}
}