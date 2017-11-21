using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionFlappyBird : MonoBehaviour
{
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
    }

    void KillBird()
    {
        Destroy(this.gameObject.GetComponent<MovingFlappyBird>());
    }
}
