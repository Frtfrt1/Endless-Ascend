using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemObtain : MonoBehaviour
{
    public float ScoreAddMin;
    public float ScoreAddMax;
    GameObject player;
    float timer = 0f;
    bool already = false;
    public float TimeLimit;
    // Start is called before the first frame update
    void Start(){
        transform.position = new Vector3(Random.Range(-160, 180), Random.Range(160, 190), Random.Range(-120, 190));
        transform.localScale = new Vector3(4, 4, 4);
        player = GameObject.Find("Player");
    }
    void OnTriggerEnter(Collider other){
        if(other.tag!="Player"||already) return;
        Destroy(gameObject);
        already = true;
        other.GetComponent<RealMovement>().score+= Random.Range(ScoreAddMin, ScoreAddMax);
        return;
    }
    void OnTriggerStay(Collider other){
        if(other.tag!="blocks") return;
        transform.Translate(new Vector3(0, 5.4f *  Time.deltaTime * (1+System.MathF.Abs(player.GetComponent<RealMovement>().score/20)), 0));
    }
    // Update is called once per frame
    void Update()
    {
        timer+=Time.deltaTime;
        if(timer>=TimeLimit) Destroy(gameObject);
    }
}
