using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public float Score=0;
    public float highscore;

    public Text scoretext;
    public Text highscoretext;
    void Start()
    {
        Score=0;
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = Score.ToString();
        
    }
}
