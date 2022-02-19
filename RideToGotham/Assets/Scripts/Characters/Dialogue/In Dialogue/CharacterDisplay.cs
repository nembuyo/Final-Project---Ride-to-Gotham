using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterDisplay : MonoBehaviour
{
    public CharacterDetails deets;

    public TMP_Text nameText;
    public Image iconImage;

    public GameObject descriptionBox;

    void Start()
    {
        nameText.text = deets.charaName;
        iconImage.sprite = deets.icon;
    }
}
