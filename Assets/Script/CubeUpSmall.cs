using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeUpSmall : MonoBehaviour
{
    public bool reversed = false;
    public float speed;
    GameObject player;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other){
        if(other.tag!="newwall") return;
        Destroy(gameObject);
    }
    void Start()
    {
        transform.position = new Vector3(UnityEngine.Random.Range(-160, 180), UnityEngine.Random.Range(-70, -150), UnityEngine.Random.Range(-120, 190));
        int a = UnityEngine.Random.Range(1, 5);
        if(a==3) transform.rotation = Quaternion.LookRotation(new Vector3(UnityEngine.Random.Range(-360, 360), UnityEngine.Random.Range(-360, 360), UnityEngine.Random.Range(-360, 360)));
        transform.localScale = new Vector3(UnityEngine.Random.Range(0.5f, 5f), UnityEngine.Random.Range(0.5f, 5f), UnityEngine.Random.Range(0.5f, 5f));
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
    // Start is called before the first frame update
        if(!reversed) transform.Translate(new Vector3(0, 5 * Time.deltaTime * speed * (1+System.MathF.Abs(player.GetComponent<RealMovement>().score/20)), 0));
        else transform.Translate(new Vector3(0, 5 * Time.deltaTime * MathF.Abs(100-speed) * (1+System.MathF.Abs(player.GetComponent<RealMovement>().score/20)), 0));
        if(transform.position.y>=500) Destroy(gameObject);
    }
}
