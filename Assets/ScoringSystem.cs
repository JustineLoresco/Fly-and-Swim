using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public int TheScore;
    public Text ScoreText; 
    
    void Start(){
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        AddScore();
    }

    void AddScore()
    {
        Score.score++;
        ScoreText.text = Score.score.ToString();  
    }
}
