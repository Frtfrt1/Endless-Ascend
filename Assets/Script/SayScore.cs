using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SayScore : MonoBehaviour
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
        txt.text = "Score : " + player.GetComponent<RealMovement>().score.ToString("F2");
    }
}
