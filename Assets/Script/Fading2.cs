using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Fading2 : MonoBehaviour
{
    public Image img;
    float fc = 0f;
    // Start is called before the first frame update
    public void Fading()
    {
        if (fc >= 0.5f)
        {
            return;
        }
        fc += 0.01f;
        img.color = new Color(0, 0, 0, fc);
        Invoke("Fading", 0.01f);
        return;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
