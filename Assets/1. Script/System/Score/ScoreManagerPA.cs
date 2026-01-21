using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManagerPA : MonoBehaviour
{
    public int score_pa;
    public int highscore_pa;

    public Text scoretext_pa;
    public Text highscoretext_pa;



    void Start()
    {
        highscore_pa = PlayerPrefs.GetInt("Highscore_pa");

        InvokeRepeating("ScorePlus_pa", 1f, 1f);



    }

    void ScorePlus_pa()
    {
        score_pa++;
        scoretext_pa.text = score_pa.ToString();
    }


    void Update()
    {

        //score += (int)Time.deltaTime;


        scoretext_pa.text = score_pa.ToString();
        highscoretext_pa.text = highscore_pa.ToString();

        highscore_pa = PlayerPrefs.GetInt("Highscore_pa");

        if (score_pa > highscore_pa)
        {
            PlayerPrefs.SetInt("Highscore_pa", score_pa);
        }


    }
}
