﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody enemyRB;
    GameObject player;
    public float speed = 100.0f;

    private float yBoundary = -15.0f;

    //public int Length { get; internal set; }

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        enemyRB = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y< yBoundary)
        {
            Destroy(gameObject);
        }

        Vector3 seekDirection = (player.transform.position - transform.position).normalized;
        enemyRB.AddForce(seekDirection * speed * Time.deltaTime);

    }
}
