using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionFlappyBird : MonoBehaviour
{
    public CanvasGroup resetPanel;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Pipe")
        {
            KillBird();
        }
        else if (coll.gameObject.tag == "Score")
        {
            this.GetComponent<ScoringFlappyBird>().currentScore++;
        }
    }

    void OnBecameInvisible()
    {
        KillBird();
        Time.timeScale = 0;

        if(resetPanel != null)
        {
            resetPanel.alpha = 1;
            resetPanel.interactable = true;
            resetPanel.blocksRaycasts = true;
        }
    }

    void KillBird()
    {
        Destroy(this.gameObject.GetComponent<MovingFlappyBird>());
    }
}
