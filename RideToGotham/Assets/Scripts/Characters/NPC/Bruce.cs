using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class Bruce : Characters
{
    [SerializeField] private MoveBoat boat;
    [SerializeField] private Transform Boat;
    [SerializeField] private Transform Dock;
    
    [SerializeField] private Transform Player;
    [SerializeField] private float counter = 10f;

    private void Start()
    {
        animator.SetBool("isNotOnDock", true);
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Boat")
        {
            animator.SetBool("isWalking", false);
            boat.isMoving = false;
            animator.SetBool("isNotOnDock", false);
     
        }
    }
    public void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, Dock.position, speed * Time.deltaTime);
        transform.LookAt(Boat);
        animator.SetBool("isLooking", false);
        animator.SetBool("isWalking", true);
    }

    void Update()
    {
        if(counter > 0)
        {
            counter -= Time.deltaTime;
            animator.SetBool("isLooking", false);
           
        }
        else
        {
            animator.SetBool("isLooking", true);
            counter = 20f;
        }

       if(boat.dockIsActive && boat.isMoving)
        {
            Move();
        }
    }
}
