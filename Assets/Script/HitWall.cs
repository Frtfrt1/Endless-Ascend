using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class HitWall : MonoBehaviour
{
    public GameObject DeathBringer;
    public GameObject player;
    public GameObject image;
    private void OnTriggerEnter(Collider other){
        if(other.tag != "wall"&&other.tag!="killer") return;
        player.GetComponent<RealMovement>().enabled = false;
        image.GetComponent<Fading2>().Fading();
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        if(gameObject.GetComponent<RealMovement>().score>PlayerPrefs.GetFloat("score134")){
            PlayerPrefs.SetFloat("score134", gameObject.GetComponent<RealMovement>().score);
            GameObject.Find("Best").GetComponent<SayYourNewBestScore>().changed = true;
        }
        GameObject.Find("Best").GetComponent<SayYourNewBestScore>().NowSay();
        Instantiate(DeathBringer, player.transform);
        Debug.Log("ouch");
    }
}
