﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hittingtarget : MonoBehaviour
{
    // Use this for initialization

    private int InspectScore;
    public int scoreVal = 0; 
    public int currentScore = 0;
    public int highscore = 0;


    private void Start()
    {
        scoreVal = InspectScore;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Bullet(Clone)")
        {
            //float translation = Time.deltaTime * 1000;
            Destroy(col.gameObject);
            scoreVal++;
            //GetComponent<score>().addToScore = scoreVal;
            print("current score value: " + scoreVal);
        }
    }
    private void Update()
    {
        if (scoreVal > highscore)
            highscore = scoreVal;
        print("high score: " + highscore);
        //GameObject.Find("highscore").GetComponent<score>().count = highscore;
    }



}