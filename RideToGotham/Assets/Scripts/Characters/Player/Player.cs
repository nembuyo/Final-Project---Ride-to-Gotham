using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class Player : Characters
{

    [SerializeField] private DialogueTrigger diaTrig;

    [SerializeField] private GameObject instructionBox1;
    [SerializeField] private GameObject instructionBox2;

    void Start()
    {
        Debug.Log("Press WASD or the arrow keys to move, R to run");
  
        diaTrig.dialogueIsPlaying = false;
        instructionBox1.SetActive(true);
        instructionBox2.SetActive(false);
    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "Water")
        {
            Debug.Log("Hey! Get out of there! You're not going to catch anything in there");
        }
    }

    public void ContinueButton()
    {
        instructionBox1.SetActive(false);
        instructionBox2.SetActive(true);
    }

    public void EndConvo()
    {
        instructionBox2.SetActive(false);
    }

    void FixedUpdate()
    {
        if (diaTrig.dialogueIsPlaying)
        {
            speed = 0;
            animator.SetBool("isWalking", false);
        }
        else
        {
            PlayerMovement();
        }
    }


}   
