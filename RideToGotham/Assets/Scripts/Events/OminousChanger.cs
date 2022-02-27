using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OminousChanger : MonoBehaviour
{

    public GameObject sceneBox;
    [SerializeField] private AudioManager _audio;
 
    void Start()
    {
        _audio = AudioManager._instance;
        sceneBox.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        _audio.Play("DialogueStart");
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            sceneBox.SetActive(true);
        }
    }

    public void Stay()
    {
        sceneBox.SetActive(false);
    }


}
