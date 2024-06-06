using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground_spawn : MonoBehaviour
{
    public GameObject ground;

    public float spawnRate = 2;
    private float timer = 0;

    void Start ()
    {
        spawnGround ( );
    }

    void Update ()
    {
        if ( timer < spawnRate )
        {
            timer += Time.deltaTime;
        }

        else
        {
            spawnGround ( );
            timer = 0;
        }
    }

    void spawnGround ()
    {
        Instantiate ( ground, transform.position, transform.rotation );
    }
}
