using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 initialDifference;
    [SerializeField] private Transform followPlayer;
    private Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        initialDifference = followPlayer.position - transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        var o = followPlayer.position - initialDifference;
        transform.position = o;
        

        if (direction != Vector3.zero)
        {
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.15f);
        }
    }
}
