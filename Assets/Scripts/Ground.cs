using UnityEngine;
using System.Collections;

public class Jamminger : MonoBehaviour
{
    [SerializeField]
    GameObject mExplosionPrefab;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer("ground"))
        {
            Destroy(col.gameObject);

        }
    }
}
