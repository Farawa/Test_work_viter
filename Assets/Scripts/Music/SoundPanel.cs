using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SoundPanel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI label;
    [SerializeField] private Slider slider;

    private void Awake()
    {
        slider.onValueChanged.AddListener(SetVolume);
        UpdateLabel();
    }

    private void SetVolume(float volume)
    {
        PrefsSaver.SaveFloat(SaveKey.musicVolume, volume);
        MessagesManager.SendMessage(new SetMusicVolume(volume));
        UpdateLabel();
    }

    private void UpdateLabel()
    {
        var displayVolume = Mathf.RoundToInt(PrefsSaver.GetFloat(SaveKey.musicVolume, 1) * 100);
        label.text = "Звук " + displayVolume + "%";
    }
}
