using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStage1 : MonoBehaviour
{
    //Player related variables
    public float movementSpeed;

    public void Start()
    {
        Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
        gameObject.GetComponent<Renderer>().material.color = newColor;
    }

    public void Update()
    {
        //Player Movement
        transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * Time.deltaTime * (movementSpeed - 2));

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * Time.deltaTime * (movementSpeed - 2));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 650f);
        }
    }

}
