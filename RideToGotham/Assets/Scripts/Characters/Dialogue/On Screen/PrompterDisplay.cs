using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PrompterDisplay : MonoBehaviour
{
    public Prompter prompter;

    public Image iconImage;
    public TMP_Text commandText;
    public GameObject commandBox;
  

    void Start()
    {
        commandBox.SetActive(false);

        commandText.text = prompter.command;
        iconImage.sprite = prompter.icon;
    }

}
