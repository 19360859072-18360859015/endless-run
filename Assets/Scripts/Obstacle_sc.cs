using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_sc : MonoBehaviour
{
    Player_sc playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GameObject.FindObjectOfType<Player_sc>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            playerMovement.Die();
        }
    }
}
