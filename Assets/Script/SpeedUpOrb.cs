using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpOrb : MonoBehaviour
{
    public float SpeedConMin;
    public float SpeedConMax;
    GameObject player;
    float timer = 0f;
    public float TimeLimit;
    // Start is called before the first frame update
    void Start(){
        transform.position = new Vector3(Random.Range(-160, 180), Random.Range(160, 190), Random.Range(-120, 190));
        player = GameObject.Find("Player");
    }
    void OnTriggerEnter(Collider other){
        if(other.tag!="Player") return;
        Destroy(gameObject);
        if((other.GetComponent<RealMovement>().speed>=200&&SpeedConMin>0)||(other.GetComponent<RealMovement>().speed<=10&&SpeedConMin<0)) return;
        other.GetComponent<RealMovement>().speed+= Random.Range(SpeedConMin, SpeedConMax);
    }
    void OnTriggerStay(Collider other){
        if(other.tag!="blocks") return;
        transform.Translate(new Vector3(0, player.GetComponent<RealMovement>().speed * Time.deltaTime, 0));
    }
    // Update is called once per frame
    void Update()
    {
        timer+=Time.deltaTime;
        if(timer>=TimeLimit) Destroy(gameObject);
        else if(timer>=TimeLimit-5f) gameObject.GetComponent<MeshRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
    }
}
