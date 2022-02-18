using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Characters
{

    [SerializeField] DialogueManager diaman;
 
    void Start()
    {
        Debug.Log("Press WASD or the arrow keys to move, R to run");
    }

    void FixedUpdate()
    {
        if(diaman.dialogueIsPlaying)
        {
            speed = 0;
        }
        else
        {
            PlayerMovement();
        }
       
    }
}
