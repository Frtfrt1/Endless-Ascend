using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamXXY : MonoBehaviour
{
    GameObject camHold;
    // Start is called before the first frame update
    void Start()
    {
        camHold = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Camera.main.transform.position = camHold.transform.position;
    }
}
