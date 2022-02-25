using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nabrak : MonoBehaviour

{
    public PlayerController diam;
    Animator animasi;

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
        }


    }
}
