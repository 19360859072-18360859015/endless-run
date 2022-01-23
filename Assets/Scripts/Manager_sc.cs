using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager_sc : MonoBehaviour
{
    [SerializeField] public Text _scoreText;
    public GameObject Coin;
    public int score;
    void Start()
    {
        score = 0;
        score = PlayerPrefs.GetInt("score", 0);

    }

    
    void Update()
    {
        UpdateScore();
    }

    public void UpdateScore()
    {
        _scoreText.text = "Score: " + score.ToString("0");
        PlayerPrefs.SetInt("score", score);

        if(score == 5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
