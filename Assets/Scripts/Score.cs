using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text finalScoreText;
    int myscore = 0;
    // Update is called once per frame
    void Update()
    {
        scoreText.text = myscore.ToString();
        finalScoreText.text = "Score:" + myscore.ToString();
    }

    public void AddScore(int score)
    {
        myscore = myscore + score; 
    }
}
