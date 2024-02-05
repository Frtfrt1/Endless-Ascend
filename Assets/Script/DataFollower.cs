using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataFollower : MonoBehaviour
{
    float score;
    public Text t;
    // Start is called before the first frame update
    void Start()
    {
        t = GameObject.Find("sc").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.HasKey("score134"))
        {
            score = PlayerPrefs.GetFloat("score134");
        }
        else
        {
            PlayerPrefs.SetFloat("score134", 0);
            score = 0;
        }
        t.text = "Best Score : " + score.ToString("F2");
    }
}
