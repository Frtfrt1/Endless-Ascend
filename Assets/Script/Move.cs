using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float x;
    public float y;
    public Transform oen;
    float xRotate;
    float yRotate;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * x;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * y;
        yRotate += mouseX;
        xRotate -= mouseY;
        xRotate = Mathf.Clamp(xRotate, -90f, 90f);
        transform.rotation = Quaternion.Euler(xRotate, yRotate, 0);
        oen.rotation = Quaternion.Euler(0, yRotate, 0);
    }
}
