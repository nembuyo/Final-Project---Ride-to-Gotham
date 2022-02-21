using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OminousThings : MonoBehaviour
{
    [SerializeField] private GameObject commandPanel;
    [SerializeField] private GameObject secondOminousCube;
    [SerializeField] private bool hasTalked;
    [SerializeField] private bool hasTalkedTwice;
    void Start()
    {
        commandPanel.SetActive(true);
        secondOminousCube.SetActive(false);
        hasTalked = false;
        hasTalkedTwice = false; 

    }

    public void EndConvo()
    {
        commandPanel.SetActive(false);
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(hasTalked)
            {
                hasTalkedTwice = true;
            }
        }
    }
    public void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            hasTalked = true;
            if(hasTalked)
            {

                transform.position = new Vector3(172.4f, 3.85f, -372f);
               
            }
            if(hasTalkedTwice)
            {
                secondOminousCube.SetActive(true);
                gameObject.SetActive(false);
            }
        }
    }




}
