using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSummon : MonoBehaviour
{
    public GameObject[] OBJs;
    public int[] prob;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i<OBJs.Length; i++){
            int p = Random.Range(1, prob[i]);
            if(p==1){
                Instantiate(OBJs[i], transform);
            }
        }
    }
}
