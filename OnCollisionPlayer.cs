using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionPlayer : MonoBehaviour
{
    public ParticleSystem explosion;

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity);
        }
        else if (other.gameObject.CompareTag("Jeepcar"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity);
        }
    }
}
