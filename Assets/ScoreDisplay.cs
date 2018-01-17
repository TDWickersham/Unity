using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

    public Text scoreLabel;
    public BallController player;
	// Use this for initialization
	void Start ()
    {
        player = FindObjectOfType<BallController>();
        scoreLabel = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        scoreLabel.text = player.score.ToString();
	}
}
