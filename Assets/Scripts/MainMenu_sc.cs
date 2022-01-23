using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu_sc : MonoBehaviour
{
    private int sceneContinue;
    
    // Start is called before the first frame update
    void Start()
    {   
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ContinueGame()
    {
        sceneContinue = PlayerPrefs.GetInt("SavedScene");

        if (sceneContinue != 0)
        {
            SceneManager.LoadScene(sceneContinue);
        }
        else
        {
            return;
        }
    }

    public void Playgame()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(1);
    }

}
