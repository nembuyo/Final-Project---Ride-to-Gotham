using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fishing : MonoBehaviour
{
    [SerializeField] private AudioManager _audio;
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject followCamera;
    [SerializeField] private GameObject fishingCamera;
    [SerializeField] private Characters characters;

    [SerializeField] private FishingRod fishingRod;
    [SerializeField] private float fishingTime;
    [SerializeField] private GameObject fishMan;
    [SerializeField] private bool isFishing;

    [SerializeField] private GameObject gotFishBox;
    [SerializeField] private GameObject didNotFishBox;
    [SerializeField] private GameObject fishingQuery;
    [SerializeField] private GameObject fishingPrompter;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        gotFishBox.SetActive(false);
        didNotFishBox.SetActive(false);
        fishingQuery.SetActive(false);
        fishingCamera.SetActive(false);
        fishingPrompter.SetActive(false);

        Debug.Log("Press WASD or the arrow keys to move, R to run");
    }

    public void StartFishing()
    {
        fishingCamera.SetActive(true);
        followCamera.SetActive(false);
        animator.SetBool("isFishing", true);
        Fish();
        isFishing = true;
        transform.position = new Vector3(-3.17f, 0.024f, 51.001f);
         fishingPrompter.SetActive(false);
        characters.DisableMovement();
    }

    public void Fish()
    {
        fishingTime -= Time.deltaTime;
        if (fishingTime <= 1)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GotFish();
            }
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            NoFish();
        }
    }

    public void GotFish()
    {
        fishMan.SetActive(true);
        animator.SetBool("caughtSomething", true);
        gotFishBox.SetActive(true);
        didNotFishBox.SetActive(false);
        fishingTime += 20;
        fishingPrompter.SetActive(false);
    }

    public void NoFish()
    {
        animator.SetBool("didntCatch", true);
        didNotFishBox.SetActive(true);
        gotFishBox.SetActive(false);
        fishingTime = 10;
        fishingPrompter.SetActive(false);
    }

    public void ContinueFishing()
    {
        StartFishing();
        fishingQuery.SetActive(false);
        _audio.Play("Rise02");
    }

    public void ExitFishing()
    {
        isFishing = false;
        animator.SetBool("caughtSomething", false);
        animator.SetBool("didntCatch", false);
        fishingCamera.SetActive(false);
        followCamera.SetActive(true);
        animator.SetBool("isFishing", false);
        didNotFishBox.SetActive(false);
        gotFishBox.SetActive(false);
        fishingPrompter.SetActive(false);
    }

    public void IsNotFishing()
    {
        fishingQuery.SetActive(false);
        fishingPrompter.SetActive(false);
    }

    public void OnCollisionStay(Collision collision)
    {
        if (fishingRod.hasFishingRod)
        {
            if (collision.gameObject.tag == "FishingBox")
            {
                fishingPrompter.SetActive(true);
                if (Input.GetKey(KeyCode.Space))
                {
                    _audio.Play("DialogueStart");
                    Debug.Log("Is this working?");
                    fishingQuery.SetActive(true);
                    fishingPrompter.SetActive(false);
                }
            }
        }
    }
    public void OnCollisionExit(Collision collision)
    {
        fishingPrompter.SetActive(false);
    }

    public void Update()
    {
       if(isFishing)
        {
            Fish();
        }
    }





}
