using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPosition : MonoBehaviour
{
    [SerializeField] private Vector3 positionScale;

    private void Update()
    {
        transform.position += positionScale;
    }
}
