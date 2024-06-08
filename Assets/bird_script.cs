using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_script : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public logic logic;
    public bool birdIsAlive = true;

    void Start ()
    {
        logic = GameObject.FindGameObjectWithTag ( "Logic" ).GetComponent<logic> ( );
    }

    void Update ()
    {
        if ( ( Input.GetKeyDown ( KeyCode.Space ) == true || Input.GetMouseButtonDown ( 0 ) == true ) && birdIsAlive )
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D ( Collision2D collision )
    {
        logic.gameOver ();
        birdIsAlive = false;
    }
}
