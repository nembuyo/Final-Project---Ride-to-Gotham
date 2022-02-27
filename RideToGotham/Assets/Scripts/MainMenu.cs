using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject panel;
    public GameManager gameManager;

    private void Start()
    {
        panel.SetActive(false);
    }

    public void GameQuit()
    {
        gameManager.Quit();
    }

    public void About()
    {
        panel.SetActive(true); 
    }

    public void Back()
    {
        panel.SetActive(false);
    }

}
