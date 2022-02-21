using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "player")
        {
            Application.Quit();
            Debug.Log("Quit");
        }

    }

}
