using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text secondsPlayingText;
    float secondsPlaying = 0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("IncreaseSecond", 0f, 0.1f);

    }
    void IncreaseSecond()
    {
        secondsPlaying += 0.1f;
        secondsPlayingText.text = secondsPlaying.ToString();
    }



    void Update()
    {

    }
}
