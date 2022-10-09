using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
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
        MessagesManager.SendMessage(new SetModalMessage(ModalType.non));
    }
}
