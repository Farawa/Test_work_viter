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

    public void SetMessage(Message message)
    {
        if (message is SetWindowMessage msg)
        {
            WindowsManager.SetWindow(msg.windowType);
        }
    }
}
