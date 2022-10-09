using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/DataScriptable", order = 1)]
public class GameData : ScriptableObject
{
    public GameObject[] windowPrefabs;
    public GameObject[] modalWindows;
    public GameObject elementPrefab;
}
