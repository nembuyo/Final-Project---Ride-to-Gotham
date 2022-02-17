using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveClouds : MonoBehaviour
{
    public Vector3 dir;
    [SerializeField] private float speed;
    void Update()
    {
        transform.position += speed * Time.deltaTime * dir;
    }
}
