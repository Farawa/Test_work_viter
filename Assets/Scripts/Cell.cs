using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public Element element;
    public bool IsCalptured()
    {
        if (element != null)
        {
            return true;
        }
        return false;
    }
}
