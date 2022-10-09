using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetElementPlaceMessage : Message
{
    public Element element;
    public Vector3 place;

    public SetElementPlaceMessage(Element element,Vector3 place)
    {
        this.element = element;
        this.place = place;
    }
}
