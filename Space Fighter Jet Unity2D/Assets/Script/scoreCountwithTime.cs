using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreCountwithTime : MonoBehaviour
{
    public Text score;
    public Text ScoreMenu_Score;

    static public float myScore;
    public float Temp_Score;

    public playerHealthControl playerHealth;

    void Update()
    {
        if (playerHealth.hitCheck == true)
        {
            myScore = 0;
            PlayerPrefs.SetInt("current_Score", (int)myScore);
        }

        if (playerHealth.gameover == false)
        {
            myScore += Time.deltaTime / 2;
            score.text = myScore.ToString("0");
            ScoreMenu_Score.text = myScore.ToString("0");

            PlayerPrefs.SetInt("current_Score", (int)myScore);
        }
    }
}
