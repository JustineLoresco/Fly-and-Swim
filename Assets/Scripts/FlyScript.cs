 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlyScript : MonoBehaviour{

    public Gamemanager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SoundManagerScript.PlaySound("tap");
            //Jump
            rb.velocity = Vector2.up * velocity;
        }
    }

      private void OnCollisionEnter2D(Collision2D collision){
          gameManager.GameOver();
          SoundManagerScript.PlaySound("out");
    }
    private void Awake()
    {
        
    }

}





