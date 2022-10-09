using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DataManager
{
    private static GameData gameData;
    public static GameData GameData
    {
        get
        {
            if (gameData == null)
            {
                gameData = Resources.Load("GameData") as GameData;
            }
            return gameData;
        }
    }
}
