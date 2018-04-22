using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HittingTargetFirst : MonoBehaviour
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
        if (col.gameObject.name == "ball")
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
    void updatingscores()
    {
        //GameObject.Find("highscore").GetComponent<score>().currentScore = highscore;
    }
}