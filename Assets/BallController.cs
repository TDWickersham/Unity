﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    public Rigidbody rb;
    public float speed;
    public int score;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(horizontal, 0, vertical);
        rb.AddForce(move * speed * Time.deltaTime);
		

    }
}
