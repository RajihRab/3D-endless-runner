using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUI : MonoBehaviour
{

    private float movementSpeed = 7f;
    private Rigidbody enemyrb;
    private GameObject player;
    private float reactDistan = 40f;
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
            if(distance > 8f)
            {
                targetPos.z += (distance / 3f);
            }

            lookDirection = (targetPos - transform.position).normalized;
            enemyrb.AddForce(lookDirection * movementSpeed);
        }
        else
        {
            lookDirection = (targetPos - transform.position).normalized;
            enemyrb.AddForce(lookDirection * movementSpeed * 0.3f);
        }
        
        if((transform.position.z - player.transform.position.z) < -3f)
        {
            Destroy(gameObject);
        }
    }

 
    
}
