using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SayHeight : MonoBehaviour
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
        txt.text = "y/" + (player.transform.position.y - 4.70f).ToString("F2");
    }
}
