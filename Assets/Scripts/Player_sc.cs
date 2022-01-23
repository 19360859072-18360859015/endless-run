using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_sc : MonoBehaviour
{
    Manager_sc score;

    float horizontalInput;
    [SerializeField] float horizontalMultiplier = 2;
    public float speed = 5;
    public float maxSpeed = 15;
    [SerializeField] Rigidbody rb;
    bool alive = true;
    private bool isGrounded = true;
    public GameObject GameOverPanel;

    private void FixedUpdate()
    {
        if (!alive)
        {
            return;
        }

        Vector3 forwardMove = transform.forward * Time.fixedDeltaTime * speed;
        Vector3 horizontalMove = transform.right * Time.fixedDeltaTime * horizontalInput * speed * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);

        if(rb.velocity.y == 0.0f)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }

        if(Input.GetAxis("Jump") > 0.0f && isGrounded)
        {
            rb.AddForce(new Vector3(0,300.0f,0), ForceMode.Force);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        speed = PlayerPrefs.GetFloat("speed");
        string scoreObject = "Manager";
        score = GameObject.Find(scoreObject).GetComponent<Manager_sc>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); //left, right, a, d

        IncreaseSpeed();

        if(transform.position.y < -5)
        {
            Die();
        }
    }

    public void Die()
    {
        alive = false;
        GameOverPanel.SetActive(true);
        speed = 5;
        score.score = 0;

    }

    void Restart()
    {
        SceneManager.LoadScene(1); //restart
        speed = 5;
        score.score = 0;
    }
    
    void IncreaseSpeed()
    {
        if (speed < maxSpeed)
        {
            speed += 0.5f * Time.deltaTime; //hiz artisi
        }

        PlayerPrefs.SetFloat("speed", speed);
    }
}
