using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public int score;
    public int highscore;

    public Text scoretext;
    public Text highscoretext;



    void Start()
    {
        highscore = PlayerPrefs.GetInt("Highscore");

        InvokeRepeating("ScorePlus", 1f, 1f);



    }

    void ScorePlus()
    {
        score++;
        scoretext.text = score.ToString();
    }


    void Update()
    {

        //score += (int)Time.deltaTime;


        scoretext.text = score.ToString();
        highscoretext.text = highscore.ToString();

        highscore = PlayerPrefs.GetInt("Highscore");

        if (score > highscore)
        {
            PlayerPrefs.SetInt("Highscore", score);
        }


    }
}
