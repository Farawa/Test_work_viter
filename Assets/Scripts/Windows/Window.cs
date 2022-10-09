using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Window : MonoBehaviour
{
    public abstract WindowType GetWindowType();

    public abstract void Enable();

    public abstract void Disable();
}
