using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class splashscreen : MonoBehaviour
{
    float time,second;
    void Start()
    {
        second = 5;
        Invoke("LoadGame", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }
}
