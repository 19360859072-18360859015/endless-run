using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin_sc : MonoBehaviour
{
    Manager_sc score;
    
    void Start()
    {
        string scoreObject = "Manager";
        score = GameObject.Find(scoreObject).GetComponent<Manager_sc>();
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collesion)
    {
        if(collesion.gameObject.name == "Player")
        {
            score.score++;
            Destroy(this.gameObject);
        }
    }
}
