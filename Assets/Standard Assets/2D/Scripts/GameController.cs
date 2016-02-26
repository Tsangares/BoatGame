﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {
    public Text scoreText;
    private int scoreL, scoreR;
    private int aGoal = 1;
    public int numPlayer = 2;
	// Use this for initialization
	void Start () {
        scoreL = 0;
        scoreR = 0;
        updateText();
	}
	// Update is called once per frame
	void Update () {
	    
	}
    public void AddScoreL()
    {
        scoreL = scoreL + aGoal;
        updateText();
    }
    public void AddScoreR()
    {
        scoreR = scoreR + aGoal;
        updateText();
    }
    public void updateText()
    {
        scoreText.text = scoreL + "/" + scoreR;
    } public void setPlayerCount (int inputPlayerCount)
    {
        if (numPlayer % 2 != 0)
        {
            Debug.Log("bad player count, changed to 2");
            numPlayer = 2;
        } else
        {
            numPlayer = inputPlayerCount;
        }
    }
}