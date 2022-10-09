using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWindow : Window
{
    
    public override void Disable()
    {
        Debug.Log("dissable game window");
    }

    public override void Enable()
    {
        Debug.Log("enable game window");
    }

    public override WindowType GetWindowType()
    {
        return WindowType.game;
    }
}
