using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu_sc : MonoBehaviour
{
    public GameObject pauseMenuCanvas;
    private bool pauseMenuFlag = false;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(pauseMenuFlag)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        
    }

    public void Resume()
    {
        pauseMenuCanvas.SetActive(false);
        Time.timeScale = 1f;
        pauseMenuFlag = false;
    }

    public void Pause()
    {
        pauseMenuCanvas.SetActive(true);
        Time.timeScale = 0f;
        pauseMenuFlag = true;
    }

    
}