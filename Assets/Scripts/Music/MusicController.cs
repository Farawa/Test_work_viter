using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MusicController : MonoBehaviour, ISubscriber
{
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PrefsSaver.GetFloat(SaveKey.musicVolume, 1);
        MessagesManager.Subscribe(this);
    }

    private void OnDestroy()
    {
        MessagesManager.UnSubscribe(this);
    }

    public void ListenMessage(Message message)
    {
        if (message is SetMusicVolume volMsg)
        {
            audioSource.volume = volMsg.volume;
        }
    }
}
