using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_script : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;

    void Start ()
    {
        
    }

    void Update ()
    {
        if ( Input.GetKeyDown ( KeyCode.Space ) == true )
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
    }
}