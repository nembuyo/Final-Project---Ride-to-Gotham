using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bruce : Characters
{
    [SerializeField] private Transform Player;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            animator.SetBool("isBeingTalkedTo", true);
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.T))
            {
                transform.LookAt(Player);
                animator.SetBool("isBeingTalkedTo", false);
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            transform.rotation = Quaternion.identity;
            animator.SetBool("isBeingTalkedTo", false);
        }
    }
    void FixedUpdate()
    {
 
    }
}
