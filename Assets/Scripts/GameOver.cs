using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverpanel;
    
    
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player")== null)
        {
            gameOverpanel.SetActive(true);
        }
    }
}
