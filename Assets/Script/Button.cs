using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class Button : MonoBehaviour
{
    public void PlayG()
    {
        SceneManager.LoadScene("level 1");
    }

    public void QuitG()
    {
        Application.Quit();
    }
    
}

