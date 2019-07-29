using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carmovement : MonoBehaviour
{

    public float movementSpeed;

    public void Start()
    {

    }

    public void Update()
    {
        //Player Movement
        transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
    }
}
