using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBlock : MonoBehaviour
{
    public float speed;
    GameObject player;
    // Start is called before the first frame update
    
    void Start()
    {
        player = GameObject.Find("Player");
        if(player.GetComponent<RealMovement>().score<=20) Destroy(gameObject);
        transform.position = new Vector3(UnityEngine.Random.Range(-160, 180), UnityEngine.Random.Range(-70, -150), UnityEngine.Random.Range(-120, 190));
        float a = Random.Range(1f, 5f);
        transform.localScale = new Vector3(a, a, a);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, player.GetComponent<RealMovement>().speed * 5 * Time.deltaTime * speed, 0));
        if(transform.position.y>=500) Destroy(gameObject);
    }
}
