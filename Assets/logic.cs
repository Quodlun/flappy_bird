using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logic : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public bool gameOverBool = false;

    [ ContextMenu ( "Increase Score" ) ]
    public void addScore ( int scoreToAdd )
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString ();
    }

    public void restartGame ()
    {
        SceneManager.LoadScene ( SceneManager.GetActiveScene ().name );
        gameOverBool = false;
    }

    public void gameOver ()
    {
        gameOverScreen.SetActive ( true );
        gameOverBool = true;
    }
}
