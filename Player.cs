using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Player related variables
    public float movementSpeed;

    public void Start()
    {

    }
    
    public void Update()
    {
        //Player Movement
        transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);

        if (Input.GetKey(KeyCode.LeftArrow)) 
            
                transform.Translate(Vector3.left * Time.deltaTime * movementSpeed);
        
        if (Input.GetKey(KeyCode.RightArrow))
        
                transform.Translate(Vector3.right * Time.deltaTime * movementSpeed);
           
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //transform.Translate(Vector3.up * Time.deltaTime * movementSpeed * 10);
            
            GetComponent<Rigidbody>().AddForce(Vector3.up * 500f);
        
        }

    }
}
