using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvlControl : MonoBehaviour
{
    public int index;
    public string levelName;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //load level
            SceneManager.LoadScene(index);

            //load with scene name
            SceneManager.LoadScene(levelName);

            

        }
      

    }




}
