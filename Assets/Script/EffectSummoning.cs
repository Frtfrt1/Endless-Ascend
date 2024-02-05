using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectSummoning : MonoBehaviour
{
    public GameObject PE;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Summon(GameObject a){
        Instantiate(PE, a.transform);
        return;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
