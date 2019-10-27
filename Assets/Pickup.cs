using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{ // Rename this before proceeding

    public int pointsToAdd;

    public static int score;



    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.GetComponent<CharacterScript>() == null) //if P1 stops touch process
            return; 
        {
            ScoreManager.Addpoints(pointsToAdd);

            Destroy(gameObject);


        }

    }


}
