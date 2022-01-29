using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text scoreText;

    public void AddScore()
    {
        score++;
        Debug.Log(score);
        scoreText.text = "SCORE:" + score.ToString();
    }

   
}
