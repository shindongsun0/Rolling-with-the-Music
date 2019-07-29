using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cowmovement : MonoBehaviour
{
    public float movementSpeed;
    public float playtime;
    public void Start()
    {

    }
    public void Update()
    {
        if (Time.realtimeSinceStartup > playtime)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
        }
    }

}
