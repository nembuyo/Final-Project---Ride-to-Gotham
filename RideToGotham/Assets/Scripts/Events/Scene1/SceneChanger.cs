using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private MoveBoat boat;
    [SerializeField] private AudioManager _audio;

    private void Start()
    {
        boat.scener.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        _audio.Play("DialogueStart");
    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            boat.scener.SetActive(true);
           
        }
    }

    public void Stay()
    {
        boat.scener.SetActive(false);
    }



}
