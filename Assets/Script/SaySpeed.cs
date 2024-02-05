using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaySpeed : MonoBehaviour
{
    public Text txt;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Speed : " + player.GetComponent<RealMovement>().speed.ToString("F1");
    }
}
