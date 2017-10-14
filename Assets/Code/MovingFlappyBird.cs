﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingFlappyBird : MonoBehaviour
{
    public float jump = 50;

    public Sprite[] birdSprites;

    private int spriteIndex = 0;

    private Rigidbody2D rigidBody;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rigidBody.velocity = new Vector3(0, jump, 0);
        }
    }

    void LateUpdate()
    {
        if(Time.frameCount % 10 == 0)
        {
            spriteIndex++;
            if (spriteIndex >= birdSprites.Length)
            {
                spriteIndex = 0;
            }

            spriteRenderer.sprite = birdSprites[spriteIndex];
        }
    }
}
