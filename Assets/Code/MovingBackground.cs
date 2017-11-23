using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackground : MonoBehaviour
{
    public float movingSpeed = 0.75f;
    public float endXLocation, startXLocation;

    public PipeSpawn pipeSpawner;

    void Update()
    {
        //background moves and when is out of screen resets
        this.transform.position = new Vector3(this.transform.position.x - (movingSpeed * Time.deltaTime), this.transform.position.y, 0);

        if (this.transform.position.x < endXLocation)
        {
            pipeSpawner.SpawnPipe();

            this.transform.position = new Vector3(startXLocation, this.transform.position.y, 0);
        }
    }
}
