using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine;

public class nabrak : MonoBehaviour

{
    public PlayerController diam;
    Animator animasi;
   
    public GameObject gameOver;
    

    public AudioSource clip;
    public AudioSource stop;

    void Start()
    {
        animasi = this.GetComponent<Animator>();
       
    }

   void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Rintangan")
        {
            animasi.Play("jatuh");
            diam.enabled = false;
            clip.Play();
            stop.Stop();
            gameOver.SetActive(true);
           
        }

        if (collision.collider.tag == "Enemy")
        {
            animasi.Play("jatuh");
            diam.enabled = false;
            clip.Play();
            stop.Stop();
            gameOver.SetActive(true);

        }


    }

    
    
}
