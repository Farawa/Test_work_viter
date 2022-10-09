using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetModalMessage : Message
{
    public ModalType modalType;

    public SetModalMessage(ModalType modalType)
    {
        this.modalType = modalType;
    }
}
