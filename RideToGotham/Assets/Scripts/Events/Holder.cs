using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holder : MonoBehaviour
{
    [SerializeField] private OminousChanger changer;

    public void Start()
    {
        changer.sceneBox.SetActive(false);
    }


}
