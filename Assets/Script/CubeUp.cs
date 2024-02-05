using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeUp : MonoBehaviour
{
    public bool reversed = false;
    public float speed;
    public float scorex = 0;
    GameObject player;
    void OnTriggerEnter(Collider other){
        if(other.tag=="newwall") Destroy(gameObject);
        else return;
    }
    void OnTriggerStay(Collider other){
        if(other.tag=="Player"&&scorex==30){
            if(player.GetComponent<RealMovement>().score<=0f) return;
            player.GetComponent<RealMovement>().score -= 0.06f*Time.deltaTime;
        }
        return;
    }
    void Start()
    {
        transform.position = new Vector3(UnityEngine.Random.Range(-160, 180), UnityEngine.Random.Range(-70, -150), UnityEngine.Random.Range(-120, 190));
        int a = UnityEngine.Random.Range(1, 5);
        if(a==3) transform.rotation = Quaternion.LookRotation(new Vector3(UnityEngine.Random.Range(-360, 360), UnityEngine.Random.Range(-360, 360), UnityEngine.Random.Range(-360, 360)));
        transform.localScale = new Vector3(UnityEngine.Random.Range(0.1f, 40f), UnityEngine.Random.Range(0.1f, 40f), UnityEngine.Random.Range(0.1f, 40f));
        player = GameObject.Find("Player");
        if(player.GetComponent<RealMovement>().score<=scorex&&scorex!=0) Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(!reversed) transform.Translate(new Vector3(0, 5*  Time.deltaTime * speed * (1+System.MathF.Abs(player.GetComponent<RealMovement>().score/20)), 0));
        else transform.Translate(new Vector3(0, 5*  Time.deltaTime * MathF.Abs(100-speed) * (1+System.MathF.Abs(player.GetComponent<RealMovement>().score/20)), 0));
        if(transform.position.y>=500) Destroy(gameObject);
    }
}
