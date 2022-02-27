using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class Player : Characters
{

    [SerializeField] private DialogueTrigger diaTrig;
    [SerializeField] private Transform rayOrigin;
    [SerializeField] private float maxDistance;
    [SerializeField] private LayerMask collisionLayerMask;

    void Start()
    {
        Debug.Log("Press WASD or the arrow keys to move, R to run");
  
        diaTrig.dialogueIsPlaying = false;

    }

    public void RaycastDart()
    {
        RaycastHit hit;

        var collidedWithSomething = Physics.Raycast(rayOrigin.position, transform.forward, out hit, maxDistance, collisionLayerMask);

        if (collidedWithSomething)
        {
            Debug.Log($"This Raycast is working. it hit {hit.transform.position}");
        }

        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward * 50) * hit.distance, Color.yellow);
    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "Water")
        {
            Debug.Log("Hey! Get out of there! You're not going to catch anything in there");
        }
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
            RaycastDart();
        }
    }


}   
