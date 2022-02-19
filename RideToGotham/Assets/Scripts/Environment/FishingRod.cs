using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingRod : MonoBehaviour
{
    [SerializeField] private GameObject fishingRod;
    [SerializeField] private DialogueTrigger diaTrig;
    public bool hasFishingRod;

    private void Start()
    {
        hasFishingRod = false;
    }
    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            fishingRod.SetActive(false);
            diaTrig.choicesPanel.SetActive(false);
            diaTrig.Prompter.SetActive(false);
            hasFishingRod = true;
        }
    }

}
