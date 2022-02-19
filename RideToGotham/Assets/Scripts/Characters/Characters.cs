using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters : MonoBehaviour
{
    public Animator animator;
    [SerializeField] protected Rigidbody rb;

    //For characters that move
    [SerializeField] protected float rotationSpeed;
    public float speed;
    [SerializeField] protected Vector3 dir;

    void Start()
    {
       animator = gameObject.GetComponent<Animator>();
       rb = GetComponent<Rigidbody>();
    }

    public void PlayerMovement()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
            animator.SetBool("isWalking", true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * -1 * speed * Time.deltaTime;
            animator.SetBool("isWalking", true);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(transform.position, transform.up, Time.deltaTime * -90f * rotationSpeed);
            animator.SetBool("isWalking", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(transform.position, transform.up, Time.deltaTime * 90f * rotationSpeed);
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }

        if (Input.GetKey(KeyCode.R))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
            speed = 3;
            animator.SetBool("isRunning", true);
        }
        else
        {
            speed = 1;
            animator.SetBool("isRunning", false);
        }
     }    

    protected virtual void BruceMovement()
    {
        if (dir != Vector3.zero)
        {
            transform.position += dir * speed * Time.deltaTime;
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    }
}
