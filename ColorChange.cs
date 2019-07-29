using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class ColorChange : MonoBehaviour
{
    public bool upTodown = false;

    void Update()
    { // check every frame
        if (Input.GetKeyDown(KeyCode.Space))
        {
            upTodown = true;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bridge"))
        {
                Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
                gameObject.GetComponent<Renderer>().material.color = newColor;
            
        }
        if (other.gameObject.CompareTag("Plain") && upTodown == true)
        {
            Color newColor = new Color( Random.value, Random.value, Random.value, 1.0f );
            gameObject.GetComponent<Renderer>().material.color = newColor;

            upTodown = false;
           
        }
    }

}