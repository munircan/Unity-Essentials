using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRotate : MonoBehaviour
{
    [SerializeField] Vector3 rotateScale;


    private void Update()
    {
        transform.Rotate(rotateScale);
    }
}
