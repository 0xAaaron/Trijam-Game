using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    public GameObject gameOverUi;
    public Text scoreDisplay;
    public ScoreManager scoreThing;

    void OnTriggerEnter2D(Collider2D other)
    {
       if(other.CompareTag("player"))
       {
            GameOver();
       } 
    }

    public void GameOver()
    {
        gameOverUi.SetActive(true);
        Debug.Log("Game Over Lol Get Rekt"); 
        scoreDisplay.text = "Score: " + scoreThing.score.ToString();
    }
}
