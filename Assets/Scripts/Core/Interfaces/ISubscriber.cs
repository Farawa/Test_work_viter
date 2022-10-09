using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISubscriber
{
    public abstract void ListenMessage(Message message);
}
