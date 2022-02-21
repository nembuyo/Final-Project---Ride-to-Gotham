using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OminousThings2 : MonoBehaviour
{
    [SerializeField] private GameObject Door;
    [SerializeField] private GameObject Choices;

    void Start()
    {
        Door.SetActive(false);
    }

    public void OnCollisionEnter()
    {
        Door.SetActive(true);
    }
    public void OnCollisionExit()
    {
        gameObject.SetActive(false);
        Choices.SetActive(false);
    }

}
