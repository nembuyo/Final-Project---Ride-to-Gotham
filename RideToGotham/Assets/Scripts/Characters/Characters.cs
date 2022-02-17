using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters : MonoBehaviour
{
    [SerializeField] protected Animator animator;
    [SerializeField] protected Rigidbody rb;
    [SerializeField] protected AudioManager _audio;
    
    //For characters that move
    [SerializeField] protected float speed;
    [SerializeField] protected Vector3 dir;

    void Start()
    {
       animator = gameObject.GetComponent<Animator>();
       rb = GetComponent<Rigidbody>();
    }

    public void PlayerMovement()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(h, 0, v).normalized;

        Vector3 m_Input = new Vector3(h, 0, v);
        rb.MovePosition(transform.position + m_Input * Time.deltaTime * speed);

        if (direction != Vector3.zero)
        {
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.15f);
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }

        if(Input.GetKey(KeyCode.R))
        {
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
        //rb.MovePosition(transform.position + speed * Time.deltaTime * dir);
        //if (dir != Vector3.zero)
        //{
            //this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(dir), 0.15f);
            //animator.SetBool("isWalking", true);
        //}
        //else
       // {
            //animator.SetBool("isWalking", false);
       // }
    }
}
