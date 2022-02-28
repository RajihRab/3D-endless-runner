using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUI : MonoBehaviour
{

    private float movementSpeed = 8f;
    private Rigidbody enemyrb;
    private GameObject player;
    private float reactDistan = 50f;
    // Start is called before the first frame update
    void Start()
    {
        enemyrb = GetComponent<Rigidbody>();
        player = GameObject.Find("Target");
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);
        Vector3 lookDirection;

        Vector3 targetPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
       

        if(distance <= reactDistan)
        {
            if(distance > 5f)
            {
                targetPos.z += (distance / 2f);
            }

            lookDirection = (targetPos - transform.position).normalized;
            enemyrb.AddForce(lookDirection * movementSpeed);
        }
        else
        {
            lookDirection = (targetPos - transform.position).normalized;
            enemyrb.AddForce(lookDirection * movementSpeed * 0.2f);
        }
        
        if((transform.position.z - player.transform.position.z) < -3f)
        {
            Destroy(gameObject);
        }
    }

 
    
}
