using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fuel : MonoBehaviour {
    public Image Image;
    public float GasValue = 1;

    float timedEvent = 1;
    float timeTracker = 0;
   

    

    // Use this for initialization
    

    // Update is called once per frame
    void Update()
    {
        Image.fillAmount = GasValue;

        timeTracker += Time.deltaTime;
        if (timeTracker >= timedEvent)
        {
            if (GasValue > 0.1f)
            {
                GasValue -= 0.17f;
                timeTracker -= timedEvent;
            }
            else 
            {
                SceneManager.LoadScene("SceneFinal");
            }
        }

    }

    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.layer == LayerMask.NameToLayer("fuel1"))
        {
            GasValue += 1f;
            Destroy(coll.gameObject);
        }


    }
}