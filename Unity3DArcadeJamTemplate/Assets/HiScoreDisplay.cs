using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HiScoreDisplay : MonoBehaviour {

    public Player playerOne;
    public Player playerTwo;

    private Text text;
    private int highScore = 0;

    void Start () {
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        highScore = Math.Max(Math.Max(playerOne.score, playerTwo.score), highScore);
        text.text = string.Format("Hi-{0}", highScore.ToString("D6"));
	}
}
