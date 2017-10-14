using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingFlappyBird : MonoBehaviour
{
    public float jump = 50;

    void Update()  
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, jump, 0);
        }
    }
}
