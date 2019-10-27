using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static float score;
    Text text_score;

    private void Start()
    {
        //Declare variables
        text_score = GetComponent<Text>();
        score = 0;
    }

    public void Update()
    {
        //display score
        if (score < 0)
        {
            score = 0;
        }
        text_score.text = "" + score;
    }


    public static void Addpoints(int pointstoAdd)

    {
        //add points using Addpoints function
        score += pointstoAdd;


    }


}
