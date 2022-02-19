using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PrompterDisplay : MonoBehaviour
{
    public Prompter prompter;

    public Image iconImage;
  

    void Start()
    {
        iconImage.sprite = prompter.icon;
    }

}
