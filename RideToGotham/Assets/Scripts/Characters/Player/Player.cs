using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class Player : Characters
{

    [SerializeField] private DialogueTrigger diaTrig;
    [SerializeField] private FishingRod fishingRod;
    [SerializeField] private bool isFishing;
    [SerializeField] private float fishingTime;

    [SerializeField] private GameObject instructionBox1;
    [SerializeField] private GameObject instructionBox2;
    [SerializeField] private GameObject gotFishBox;
    [SerializeField] private GameObject didNotFishBox;

    void Start()
    {
        gotFishBox.SetActive(false);
        didNotFishBox.SetActive(false);

        Debug.Log("Press WASD or the arrow keys to move, R to run");
        isFishing = false;
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

    public void FishingTime()
    {
        animator.SetBool("isFishing", true);
        //isFishing = true;
    }

    public void GotFish()
    {
        animator.SetBool("caughtSomething", true);
        gotFishBox.SetActive(true);
        didNotFishBox.SetActive(false);

        fishingTime += 20;
    }

    public void NoFish()
    {
        animator.SetBool("didntCatch", true);
        gotFishBox.SetActive(false);
        didNotFishBox.SetActive(true);
        fishingTime = 10;
    }

    public void ContinueFishing()
    {
        FishingTime();
        animator.SetBool("didntCatch", false);
        animator.SetBool("caughtSomething", false);
        gotFishBox.SetActive(false);
        didNotFishBox.SetActive(false);
        isFishing = true;
    }    

    public void ExitFishing()
    {
        animator.SetBool("isFishing", false);
        animator.SetBool("didntCatch", false);
        animator.SetBool("caughtSomething", false);
        isFishing = false;
        speed = 1;
        gotFishBox.SetActive(false);
        didNotFishBox.SetActive(false);
        fishingTime = 10;
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

        if (fishingRod.hasFishingRod)
        {
            if (Input.GetKey(KeyCode.C))
            {
                FishingTime();
                isFishing = true;
            }
        }
        else
        {
            if(Input.GetKey(KeyCode.C))
            {
                Debug.Log("Stop trying to break the game!");
            }
        }
        if(isFishing)
        {
            speed = 0;
            fishingTime -= Time.deltaTime;
            if(fishingTime <= 1 && fishingTime >  0)
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    GotFish();
                }
            }
            else
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    NoFish();
                }
            }

        }
        else
        {
            fishingTime = 10;
        }
    }
}
