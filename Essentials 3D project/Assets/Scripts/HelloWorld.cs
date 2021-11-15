using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    [SerializeField] String myString;
    void Start()
    {
        Debug.Log(myString);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello World Update!");
    }
}
