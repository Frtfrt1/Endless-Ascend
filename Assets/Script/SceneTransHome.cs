using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneTransHome : MonoBehaviour
{
    public void OnClick()
    {
        Debug.Log("Clicked");
        GameObject.Find("Image").GetComponent<FadingOut4>().Fading();
    }
    public void GoNext()
    {
        SceneManager.LoadScene("intro scene");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
