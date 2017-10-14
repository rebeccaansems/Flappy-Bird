﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{

    public GameObject pipe;
    public Sprite topPipe, bottomPipe;

    public float startPosX;

    public void SpawnPipe()
    {
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.parent = this.transform;

        if (UnityEngine.Random.Range(0, 2) == 0)
        {
            newPipe.GetComponent<SpriteRenderer>().sprite = bottomPipe;
            newPipe.transform.position = new Vector3(startPosX, UnityEngine.Random.Range(-0.5f, -2f), -5);

            if (UnityEngine.Random.Range(0, 3) == 0 && newPipe.transform.position.y <= -0.5f)
            {
                GameObject secondaryNewPipe = Instantiate(pipe);
                secondaryNewPipe.transform.parent = this.transform;
                secondaryNewPipe.GetComponent<SpriteRenderer>().sprite = topPipe;
                secondaryNewPipe.transform.position = new Vector3(startPosX, UnityEngine.Random.Range(2 + newPipe.transform.position.y, 2f), -5);
            }
        }
        else
        {
            newPipe.GetComponent<SpriteRenderer>().sprite = topPipe;
            newPipe.transform.position = new Vector3(startPosX,UnityEngine.Random.Range(0.5f, 2f), -5);

            if (UnityEngine.Random.Range(0, 3) == 0 && newPipe.transform.position.y >= -1f)
            {
                GameObject secondaryNewPipe = Instantiate(pipe);
                secondaryNewPipe.transform.parent = this.transform;
                secondaryNewPipe.GetComponent<SpriteRenderer>().sprite = bottomPipe;
                secondaryNewPipe.transform.position = new Vector3(startPosX, UnityEngine.Random.Range(1 - newPipe.transform.position.y, -2f), -5);
            }
        }

    }
}
