using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager_SG : MonoBehaviour
{
    public int score_sg;
    public int highscore_sg;

    public Text scoretext_sg;
    public Text highscoretext_sg;



    void Start()
    {
        highscore_sg = PlayerPrefs.GetInt("Highscore_sg");

        InvokeRepeating("ScorePlus_sg", 1f, 1f);



    }

    void ScorePlus_sg()
    {
        score_sg++;
        scoretext_sg.text = score_sg.ToString();
    }


    void Update()
    {

        //score += (int)Time.deltaTime;


        scoretext_sg.text = score_sg.ToString();
        highscoretext_sg.text = highscore_sg.ToString();

        highscore_sg = PlayerPrefs.GetInt("Highscore_sg");

        if (score_sg > highscore_sg)
        {
            PlayerPrefs.SetInt("Highscore_sg", score_sg);
        }


    }
}
