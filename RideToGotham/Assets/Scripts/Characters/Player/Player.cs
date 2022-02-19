using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Characters
{

    [SerializeField] DialogueTrigger diaTrig;
 
    void Start()
    {
        Debug.Log("Press WASD or the arrow keys to move, R to run");
    }

    void FixedUpdate()
    {
        if(diaTrig.dialogueIsPlaying)
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
