using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    private int score;
    public Text scoreText;
    void Start()
    {

    }
    void Update()
    {

    }
    public void gamescore(int ringscore)
    {
        score = ringscore;
        scoreText.text = score.ToString();

    }
    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

