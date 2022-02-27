using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuidoPlayer2 : MonoBehaviour
{
    [SerializeField] private AudioManager _audio;
    private void Start()
    {
        _audio = AudioManager._instance;
        _audio.Play("Horror");
        _audio.StopPlaying("Forest");
        _audio.StopPlaying("Yume");
    }
}
