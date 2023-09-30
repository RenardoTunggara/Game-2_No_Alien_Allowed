using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class click : MonoBehaviour
{
    public AudioSource soundPlayer;

    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void play()
    {
        soundPlayer.Play();
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            ScoreScript.scoreValue += 10;
            Destroy(gameObject);
            play();
        }
    }
}
