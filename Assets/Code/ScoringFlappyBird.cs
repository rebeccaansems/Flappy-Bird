using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringFlappyBird : MonoBehaviour
{
    public int currentScore = 0;
    public Text scoringText;

    // Update is called once per frame
    void Update()
    {
        scoringText.text = currentScore.ToString("000");
    }
}
