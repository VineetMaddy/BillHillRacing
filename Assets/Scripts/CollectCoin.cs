using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CollectCoin : MonoBehaviour {

    public Text ScoreText;
    int Score = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        Score++;
      
    }
}
