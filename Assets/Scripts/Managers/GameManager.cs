using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour, ISubscriber
{
    private void Awake()
    {
        MessagesManager.Subscribe(this);
    }

    private void OnDestroy()
    {
        MessagesManager.Subscribe(this);
    }

    private void Start()
    {
        WindowsManager.SetWindow(WindowType.main);
    }

    public void ListenMessage(Message message)
    {
        if (message is SetWindowMessage windowMsg)
        {
            WindowsManager.SetWindow(windowMsg.windowType);
        }
        else if (message is SetModalMessage modalMsg)
        {
            WindowsManager.SetModal(modalMsg.modalType);
        }
    }
}
