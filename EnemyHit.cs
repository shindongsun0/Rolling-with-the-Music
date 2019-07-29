using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{

    //public ParticleSystem explosion;
  
	void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Destroy(col.gameObject);
            //Instantiate(explosion, transform.position, Quaternion.identity);
            
        }
    }

}
