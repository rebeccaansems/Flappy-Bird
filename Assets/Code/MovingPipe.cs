using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPipe : MonoBehaviour
{

    public float movingSpeed = 0.75f;
    public float endXLocation, startXLocation;


    void Update()
    {
        this.transform.position = new Vector3(this.transform.position.x - (movingSpeed * Time.deltaTime), this.transform.position.y, -5);

        if (this.transform.position.x < endXLocation)
        {
            Destroy(this.gameObject);
        }
    }
}
