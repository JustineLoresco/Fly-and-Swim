using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip playerJump, playerHit, playerStart;
    static AudioSource audioSrc;

    void Start()
    {
        playerJump = Resources.Load<AudioClip>("tap");
        playerHit = Resources.Load<AudioClip>("out");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update(){
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "tap":
                audioSrc.PlayOneShot(playerJump);
                break;
            case "out":
                audioSrc.PlayOneShot(playerHit);
                break;
        }
    }
}
