using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public GameManager gameManager;
    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "player")
        {
            gameManager.Quit();
            Debug.Log("Quit");
        }

    }

}
