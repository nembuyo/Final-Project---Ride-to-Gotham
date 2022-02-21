using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject panel;

    public void Quit()
    {
        Application.Quit();
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
