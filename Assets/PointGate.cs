using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointGate : MonoBehaviour {

    public int targetScore;
    public BallController player;
	// Use this for initialization
	void Start ()
    {
        player = FindObjectOfType<BallController>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (player.score >= targetScore)
        {
            Destroy(gameObject);
        }
	}

}
