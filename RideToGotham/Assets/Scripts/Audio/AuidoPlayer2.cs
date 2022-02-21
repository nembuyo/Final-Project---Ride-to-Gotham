using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuidoPlayer2 : MonoBehaviour
{
    [SerializeField] private AudioManager _audio;
    private void Start()
    {
        _audio.Play("Horror");
    }
}
