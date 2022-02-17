using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Characters
{
    void Start()
    {
        Debug.Log("Press WASD or the arrow keys to move");
    }

    void FixedUpdate()
    {

        PlayerMovement();
        
    }
}
