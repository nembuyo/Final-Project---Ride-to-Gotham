using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterDisplay : MonoBehaviour
{
    public CharacterDetails deets;

    public TMP_Text nameText;
    public TMP_Text descriptionText;
    public Image iconImage;

    public GameObject descriptionBox;

    void Start()
    {
        descriptionBox.SetActive(false);

        nameText.text = deets.charaName;
        descriptionText.text = deets.hoverDescription;
        iconImage.sprite = deets.icon;
    }

    public void ShowDescription()
    {
        descriptionBox.SetActive(true);
    }

    public void HideDescription()
    {
        descriptionBox.SetActive(false);
    }
}
