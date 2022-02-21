using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class LineCross : MonoBehaviour
{
    public UnityEvent onLineCross;

    public void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Boat")
        {
            onLineCross?.Invoke();
        }
    }
}
