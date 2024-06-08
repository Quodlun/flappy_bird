using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class space_to_retry : MonoBehaviour
{
    public logic logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag ( "Logic" ).GetComponent<logic> ( );
    }

    void Update()
    {
        if ( logic.gameOverBool == true && Input.GetKeyDown ( KeyCode.Space ) == true )
        {
            logic.restartGame ( );
            logic.gameOverBool = false;
        }
    }
}
