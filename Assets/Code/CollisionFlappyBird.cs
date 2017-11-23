using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionFlappyBird : MonoBehaviour
{
    public CanvasGroup resetPanel;

    private bool birdIsDead = false, birdHitPipe = false;

    private void Update()
    {
        if (this.transform.position.y < -1.3 || this.transform.position.y > 1.4)
        {
            KillBird();
        }

        if (birdHitPipe)
        {
            Vector3 fallingLocation = new Vector3(0.75f * Time.deltaTime, 0, 0);
            this.transform.position -= fallingLocation;
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Pipe")
        {
            birdHitPipe = true;
            KillBird();
        }
        else if (coll.gameObject.tag == "Score")
        {
            this.GetComponent<ScoringFlappyBird>().currentScore++;
        }
    }

    void OnBecameInvisible()
    {
        if (resetPanel != null && birdIsDead)
        {
            resetPanel.alpha = 1;
            resetPanel.interactable = true;
            resetPanel.blocksRaycasts = true;
            Time.timeScale = 0;
        }
    }

    void KillBird()
    {
        Destroy(this.gameObject.GetComponent<MovingFlappyBird>());
        birdIsDead = true;
    }
}
