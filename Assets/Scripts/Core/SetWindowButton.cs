using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetWindowButton : MonoBehaviour
{
    [SerializeField] private WindowType targetWindowType;

    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(Click);
    }

    private void Click()
    {
        MessagesManager.SendMessage(new SetWindowMessage(targetWindowType));
    }
}
