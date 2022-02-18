using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class MoveBoat : MonoBehaviour
{
    [SerializeField] private Vector3 dir;
    [SerializeField] private float speed;
    [SerializeField] private LineCross lineCross;
    [SerializeField] private GameObject _dock;
    public bool dockIsActive;
    public bool isMoving;

    public void Start()
    {
        lineCross.onLineCross.AddListener(Stop);
        lineCross.onLineCross.AddListener(Activate);
        _dock.SetActive(false);
    }

    public void Stop()
    {
        speed = 0;
    }

    public void Activate()
    {
        _dock.SetActive(true);
        dockIsActive = true;
        isMoving = true;
    }
    void Update()
    {
        transform.position += speed * Time.deltaTime * dir;
    }
}
