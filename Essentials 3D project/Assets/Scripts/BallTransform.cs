using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTransform : MonoBehaviour
{
    [SerializeField] Vector3 scale;


    private void Update()
    {
        transform.localScale += scale;
    }
}
