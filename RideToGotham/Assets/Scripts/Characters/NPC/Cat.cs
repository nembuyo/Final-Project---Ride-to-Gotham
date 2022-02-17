using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    [SerializeField] private GameObject Ilya;
    [SerializeField] private GameObject SecondCamera;
    [SerializeField] private GameObject MainCamera;
    [SerializeField] private GameObject PostEffectsOne;
    [SerializeField] private GameObject PostEffectsTwo;

    [SerializeField] Animator animator;

    private void Start()
    {
        SecondCamera.SetActive(false);
        PostEffectsTwo.SetActive(false);
        animator = gameObject.GetComponent<Animator>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Wanna see something cool?");
            Debug.Log("Press P to see it");
            animator.SetBool("isTalking", true);
        }
    }
    public void OnCollisionStay(Collision collision)
    {
        if (Input.GetKey(KeyCode.P))
        {
            MainCamera.SetActive(false);
            PostEffectsOne.SetActive(false);
            Ilya.SetActive(false);
            SecondCamera.SetActive(true);
            PostEffectsTwo.SetActive(true);
            Debug.Log("Cool, right? Post Processing baby! Press O to go back to normal!");
            Debug.Log("Press I to change the Lens Distorsion intensity, and U to return it to normal");
        }
    }
    public void OnCollisionExit(Collision collision)
    {
        animator.SetBool("isTalking", false);
    }
    public void Update()
    {
        if (Input.GetKey(KeyCode.O))
        {
            MainCamera.SetActive(true);
            PostEffectsOne.SetActive(true);
            Ilya.SetActive(true);
            SecondCamera.SetActive(false);
            PostEffectsTwo.SetActive(false);
        }
    }

}
