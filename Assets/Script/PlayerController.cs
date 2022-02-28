using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Animator animasi;
    public float jumpforce;
    Rigidbody rig;
    Transform trans;
    public float moveSpeed = 5;
    public float leftRightSpeed = 4;
    Collider coll;
    bool active = true;
    bool grounded;
    float up;
    public AudioSource clip;
    public AudioSource stop;


    void Start()
    {
        animasi = this.GetComponent<Animator>();
        rig = GetComponent<Rigidbody>();
        trans = GetComponent<Transform>();
        coll = GetComponent<Collider>();
        up = 0.085f;
    }




    void Update()
    {

        if (Physics.Raycast(transform.position + new Vector3(0.1f, 0.05f, 0f), Vector3.down, up)
          || Physics.Raycast(transform.position + new Vector3(0.1f, 0.05f, 0f), Vector3.down, up)
          || Physics.Raycast(transform.position + new Vector3(-0.1f, 0.05f, 0f), Vector3.down, up)
          || Physics.Raycast(transform.position + new Vector3(-0.1f, 0.05f, 0f), Vector3.down, up))
        {
            grounded = true;
            coll.material.dynamicFriction = 1;
            coll.material.staticFriction = 1;
            animasi.SetBool("grounded", true);
        }
        else
        {
            grounded = false;
            coll.material.dynamicFriction = 0;
            coll.material.staticFriction = 0;
            animasi.SetBool("grounded", false);
        }

        
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);


        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
            {
                trans.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
                animasi.Play("kiri");


            }

        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
            {
                trans.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
                animasi.Play("kanan");


            }

        }

        if (Input.GetButtonDown("Jump") && grounded)

        {
            animasi.Play("jump");

            rig.AddForce(Vector3.up * 4f, ForceMode.Impulse);





        }


    }


    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Finish")
        {
            animasi.Play("menang");
            clip.Play();
            stop.Stop();
        }


    }

    
}