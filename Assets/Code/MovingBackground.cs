using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackground : MonoBehaviour
{
    public float movingSpeed = 4;
    public float endXLocation, startXLocation;

    void Update()
    {
        this.transform.position = new Vector2(this.transform.position.x - (movingSpeed * Time.deltaTime), this.transform.position.y);

        if(this.transform.position.x < endXLocation)
        {
            this.transform.position = new Vector2(startXLocation, this.transform.position.y);
        }
    }
}
