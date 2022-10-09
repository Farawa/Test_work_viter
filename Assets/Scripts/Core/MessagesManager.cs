using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MessagesManager
{
    private static List<ISubscriber> subscribers = new List<ISubscriber>();

    public static void Subscribe(ISubscriber subscriber)
    {
        subscribers.Add(subscriber);
    }

    public static void UnSubscribe(ISubscriber subscriber)
    {
        subscribers.Remove(subscriber);
    }

    public static void SendMessage(Message message)
    {
        foreach(var sub in subscribers)
        {
            sub.SetMessage(message);
        }
    }
}
