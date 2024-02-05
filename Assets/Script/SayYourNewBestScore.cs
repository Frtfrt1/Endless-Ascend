using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SayYourNewBestScore : MonoBehaviour
{
    public GameObject gx;
    public bool changed = false;
    public Text txt;
    // Start is called before the first frame update
    void Start()
    {
    }
    public void NowSay(){
        Debug.Log("You Died");
        if(changed){
            txt.text = "Congrats!\nNow Your New Best Score Is\n" + PlayerPrefs.GetFloat("score134").ToString("F2");
        }else{
            txt.text = "Best Score\n" + PlayerPrefs.GetFloat("score134").ToString("F2");
        }Invoke("appear", 2f);
    }
    void appear(){
        gx.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
