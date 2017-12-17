using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CarDestroy : MonoBehaviour
{
    [SerializeField]
    GameObject mDeathParticleEmitter;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer("ground"))
        {

            Instantiate(mDeathParticleEmitter, transform.position, transform.rotation);
            Destroy(transform.parent.gameObject);
            SceneManager.LoadScene("SceneFinal");
        }

    }
}