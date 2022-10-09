using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetWindowMessage : Message
{
    public WindowType windowType;
    public SetWindowMessage(WindowType windowType)
    {
        this.windowType = windowType;
    }
}
