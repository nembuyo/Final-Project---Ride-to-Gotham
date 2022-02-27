using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer3 : MonoBehaviour
{
    public AudioManager _audio;

    void Start()
    {
        _audio = AudioManager._instance;
        _audio.Play("Ede");
        _audio.StopPlaying("Horror");
    }


}
