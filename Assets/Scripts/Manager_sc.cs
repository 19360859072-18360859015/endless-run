using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager_sc : MonoBehaviour
{
    [SerializeField] public Text _scoreText;
    public GameObject Coin;
    public float score;
    void Start()
    {
        score = 0;
        
    }

    
    void Update()
    {
        UpdateScore();
    }

    public void UpdateScore()
    {
        _scoreText.text = "Score: " + score.ToString("0");
    }
}
