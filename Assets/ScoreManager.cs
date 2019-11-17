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
        text_score = GetComponent<Text>();

        score = 0;        //text that score starts with




    }

    public void Update()
    {


        text_score.text = "" + score;




    }

    public static void Addpoints(int pointstoAdd)

    {
        score += pointstoAdd;


    }


}


