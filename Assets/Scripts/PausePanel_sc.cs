using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePanel_sc : MonoBehaviour
{
    public GameObject PausePanel;
    public bool OyunDurduMu = false;

    public void OpenPanel()
    {
        if(PausePanel != null)
        {
            bool isActive = PausePanel.activeSelf; //pause menusunu acip kapatmak icin
            PausePanel.SetActive(!isActive);
        }
    }

    public void OyunuDurdur()
    {
        if(OyunDurduMu == false)
        {  
            Time.timeScale = 0f;
            OyunDurduMu = true;
        }
        else
        {
            Time.timeScale = 1f;
            OyunDurduMu = false;
        }
        
    }
}
