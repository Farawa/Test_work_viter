using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Element : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool isPicked = false;
    private Vector3 offset;
    public bool isCanDrag;
    public Vector3 lastPosition;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!isCanDrag) return;
        isPicked = true;
        offset = transform.position - Input.mousePosition;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (!isCanDrag) return;
        isPicked = false;
        MessagesManager.SendMessage(new SetElementPlaceMessage(this, Input.mousePosition));
    }

    private void Update()
    {
        if (!isPicked||!isCanDrag)
            return;
        transform.position = Input.mousePosition + offset;
    }
}
