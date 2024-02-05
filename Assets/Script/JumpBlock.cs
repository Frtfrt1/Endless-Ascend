using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBlock : MonoBehaviour
{
    public float speed;
    GameObject player;
    public AudioClip aud;
    // Start is called before the first frame update
    
    void Start()
    {
        transform.position = new Vector3(UnityEngine.Random.Range(-160, 180), UnityEngine.Random.Range(-70, -150), UnityEngine.Random.Range(-120, 190));
        float a = Random.Range(0.1f, 10f);
        transform.localScale = new Vector3(a, a, a);
        player = GameObject.Find("Player");
    }
    void OnTriggerEnter(Collider other){
        if(other.tag!="Player") return;
        gameObject.GetComponent<AudioSource>().PlayOneShot(aud);
        player.transform.position = new Vector3(UnityEngine.Random.Range(-160, 180), UnityEngine.Random.Range(0, 100), UnityEngine.Random.Range(-120, 190));
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, player.GetComponent<RealMovement>().speed * Time.deltaTime * speed, 0));
        if(transform.position.y>=500) Destroy(gameObject);
    }
}
