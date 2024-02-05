using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FadingOut4 : MonoBehaviour
{
    public Image img;
    float fc = 0.5f;
    // Start is called before the first frame update
    public void Fading()
    {
        if (fc >= 1f)
        {
            GameObject.Find("Button").GetComponent<SceneTransHome>().GoNext();
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
