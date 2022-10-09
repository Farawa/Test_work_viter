using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainWindow : Window
{
    public override void Disable()
    {
        Debug.Log("dissable main window");
    }

    public override void Enable()
    {
        Debug.Log("enable main window");
    }

    public override WindowType GetWindowType()
    {
        return WindowType.main;
    }
}
