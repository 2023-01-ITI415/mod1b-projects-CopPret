﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]

    // Prefab for instatiating apples

    public GameObject applePrefab;

    // Speed at which the AppeTree moves

    public float speed = 1f;

    // Distance where AppleTree turns around

    public float leftAndRightEdge = 20f;

    // Chance that the AppleTree will change direction

    public float chanceToChangeDirection

    // Rate at which Apples will be instantiate

    public float secondsBetweenAppleDrop

    // Start is called before the first frame update
    void Start()
    {
        // Dropping apples every second
    }

    // Update is called once per frame
    void Update()
    {
        // Basic Movement

        Vector3 pos = transform.position;

        pos.x += speed * Time.deltaTime;

        transform.position = pos;

        // Changing Direction
    }
}