using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitFinish : MonoBehaviour

   
    
{
    public GameObject finisheOver;
    public PlayerController diam;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            //enakan kepause
            Time.timeScale = 1f;
            //atau pake animasi ya?
            diam.enabled = false;
            finisheOver.SetActive(true);
        }
    }

}
