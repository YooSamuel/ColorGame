using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour
{
    public Text secondsPlayingText;
    double secondsPlaying = 0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("IncreaseSecond", 0f, 0.01f);

    }
    void IncreaseSecond()
    {
        secondsPlaying += 0.01f;
        secondsPlayingText.text = (Math.Truncate(secondsPlaying * 100)/100).ToString();
    }



    void Update()
    {

    }
}
