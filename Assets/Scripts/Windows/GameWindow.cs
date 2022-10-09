using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GameController))]
public class GameWindow : Window
{
    public override void Disable()
    {
        Debug.Log("dissable game window");
    }

    public override void Enable()
    {
        GetComponent<GameController>().StartLevel();
    }

    public override WindowType GetWindowType()
    {
        return WindowType.game;
    }
}
