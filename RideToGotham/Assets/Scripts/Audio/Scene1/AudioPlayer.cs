using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [SerializeField] AudioManager _audio;
    // Ambience and Background Music Player
    void Start()
    {
        _audio = AudioManager._instance;

        _audio.StopPlaying("Ede");
        _audio.Play("Forest");
        _audio.Play("Yume");
        _audio.Play("Rise06");
    }
}


