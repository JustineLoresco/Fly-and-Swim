using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;

    void Awake(){
        score=0;
    }

    private void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
    }
}