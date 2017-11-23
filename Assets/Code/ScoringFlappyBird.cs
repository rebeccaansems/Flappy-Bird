using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringFlappyBird : MonoBehaviour
{
    public int currentScore = 0;
    public Text scoringText;
    
    void Update()
    {
        //update displayed score
        scoringText.text = currentScore.ToString("000");
    }
}
