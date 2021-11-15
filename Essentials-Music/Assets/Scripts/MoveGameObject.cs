using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGameObject : MonoBehaviour
{
    [SerializeField] private Vector3 position;

    private void Update()
    {
        transform.localPosition += position;
        
    }
}
