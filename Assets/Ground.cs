using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour
{
    

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer("ground"))
        {
            Destroy(gameObject);
          

        }
    }
}
