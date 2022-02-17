using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    
    void Start()
    {
        Debug.Log("Press WASD or the arrow keys to move, Q to move up and Z to move down");
    }

    void RotatingLeft()
    {
        transform.RotateAround(transform.position, transform.up, Time.deltaTime * -90f);
    }

    void RotatingRight()
    {
        transform.RotateAround(transform.position, transform.up, Time.deltaTime * 90f);
    }

    void Update()
    {
        
      
        if (Input.GetKey(KeyCode.A))
        {
            RotatingLeft();
        }
        if (Input.GetKey(KeyCode.D))
        {
            RotatingRight();
        }
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * -1 * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.position += new Vector3(0, 1, 0) * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Z))
        {
            transform.position += new Vector3(0, -1, 0) * speed * Time.deltaTime;
        }
    }
}
