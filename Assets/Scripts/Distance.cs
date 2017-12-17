using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{

    float distanceTravelled = 0;
    Vector3 lastPosition;

    void Start()
    {
        lastPosition = transform.position;
    }

    void Update()
    {
        if (lastPosition.x < transform.position.x)
        {
            distanceTravelled += Vector3.Distance(transform.position, lastPosition);
            lastPosition = transform.position;

        }
    }
}