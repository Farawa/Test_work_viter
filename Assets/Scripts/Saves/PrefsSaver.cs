using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PrefsSaver
{
    private static void Save()
    {
        PlayerPrefs.Save();
    }

    public static void SaveInt(SaveKey key, int value)
    {
        PlayerPrefs.SetInt(key.ToString(), value);
        Save();
    }

    public static int GetInt(SaveKey key, int defaultValue = 0)
    {
        return PlayerPrefs.GetInt(key.ToString(), defaultValue);
    }

    public static void SaveFloat(SaveKey key, float value)
    {
        PlayerPrefs.SetFloat(key.ToString(), value);
        Save();
    }

    public static float GetFloat(SaveKey key, float defaultValue = 0f)
    {
        return PlayerPrefs.GetFloat(key.ToString(), defaultValue);
    }

    public static void SaveString(SaveKey key, string value)
    {
        PlayerPrefs.SetString(key.ToString(), value);
        Save();
    }

    public static string GetString(SaveKey key, string defaultValue = "")
    {
        return PlayerPrefs.GetString(key.ToString(), defaultValue);
    }
}

public enum SaveKey
{
    musicVolume,

}
