using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class livesManager : MonoBehaviour
{
    public static int lives;
    public static int livestoAdd;
    Text text_lives;
    public GameObject GameOverScreen;
    public GameObject Protagonist;
    public GameObject stats;
 




    // Start is called before the first frame update
    private void Start()
    {
        text_lives = GetComponent<Text>();
        lives = 3;
        GameOverScreen.SetActive(false);

    }

    // Update is called once per frame
    private void Update()
    {

        text_lives.text = "" + lives;

        if (lives <= 0)
        {

            GameOverScreen.SetActive(true);
            Destroy(Protagonist.gameObject);
            Destroy(stats.gameObject);


        }

    }

    public static void Addpoints(int livestoAdd)
    {
        lives += livestoAdd;
    }

}

