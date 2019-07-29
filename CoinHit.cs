using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinHit : MonoBehaviour
{

    public Text score_text;
    public static int score;

    void Start()
    {
        score = 0;
        score_text.text = "Score : " + score.ToString();
    }
    //public ParticleSystem explosion;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            score += 10;
            score_text.text = "Score : " + score.ToString();
            //Instantiate(explosion, transform.position, Quaternion.identity);

        }
    }

}