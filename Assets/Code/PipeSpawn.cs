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
            newPipe.transform.position = new Vector3(startPosX, RoundToNearestHalf(UnityEngine.Random.Range(-0.5f, -2f)), -5);
        }
        else
        {
            newPipe.GetComponent<SpriteRenderer>().sprite = topPipe;
            newPipe.transform.position = new Vector3(startPosX, RoundToNearestHalf(UnityEngine.Random.Range(0.5f, 2f)), -5);
        }


    }

    private void Update()
    {

    }

    private float RoundToNearestHalf(float value)
    {
        return (float)Math.Round(value * 2) / 2;
    }
}