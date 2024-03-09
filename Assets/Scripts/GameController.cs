using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    int lives;
    public TMP_Text livestext;
    public TMP_Text scoreText;
    public static int score;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lives = (int)Variables.Scene(this).Get("health");
        if (lives == 0)
        {
            SceneManager.LoadScene("GameOver");
        }

        score = (int)Variables.Scene(this).Get("score");
        scoreText.text = "Score: " + score;
        livestext.text = "Lives: " + lives;
    }
}
