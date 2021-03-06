﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text scoreText;
    public Text hiScoreText;

    public float scoreCount;
    public float hiScoreCount;

    public float pointsPerSecond;

    public bool isScoreIncreasing;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        scoreCount += pointsPerSecond * Time.deltaTime;

        scoreText.text = "Score:" + scoreCount;
        hiScoreText.text = "High Score:" + hiScoreCount;
	}
}
