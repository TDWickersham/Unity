﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badPickUp : MonoBehaviour
{

    public int scoreAdded;
    public float rotationSpeed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationSpeed, 0, rotationSpeed / 3);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            var playerController = other.GetComponent<BallController>();
            if (playerController != null)
            {
                playerController.score -= scoreAdded;
                Destroy(gameObject);
            }
        }
    }
}