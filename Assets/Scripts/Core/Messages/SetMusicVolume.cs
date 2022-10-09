using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMusicVolume : Message
{
    public float volume;

    public SetMusicVolume(float volume)
    {
        this.volume = volume;
    }
}
