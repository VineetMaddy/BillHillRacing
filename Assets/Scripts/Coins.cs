using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour {
    
    public Text ScoreText;
    static int Score = 0;
    AudioSource coin;
    SpriteRenderer mySprite;
    void Start()
    {
        coin = GetComponent<AudioSource>();
        mySprite = GetComponent<SpriteRenderer>();
    }
    void OnTriggerStay2D (Collider2D col)
    {
        if (col.gameObject.tag =="Player")
        {
            coin.Play();
            mySprite.enabled = false;
            Destroy(gameObject.GetComponent<Collider2D>());
            Destroy(gameObject, .5f);

            Score++;
            ScoreText.text = "Coins :" + Score;

        }
    } 
}
