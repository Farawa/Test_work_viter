using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameController : MonoBehaviour, ISubscriber
{
    [SerializeField] private Cell[] fieldCells;
    [SerializeField] private Cell bigCell;
    [SerializeField] private Cell smallCell;
    [SerializeField] private Transform elementsParent;
    private List<Element> elements = new List<Element>();

    private void Awake()
    {
        MessagesManager.Subscribe(this);
    }

    private void OnDestroy()
    {
        MessagesManager.UnSubscribe(this);
    }

    public void StartLevel()
    {
        if (elements.Count != 0)
        {
            for (int i = elements.Count - 1; i >= 0; i--)
            {
                Destroy(elements[i].gameObject);
            }
        }
        print("capture cell is " + fieldCells[3].IsCalptured());
        CreateElement(fieldCells[3], false);
        CreateElement(fieldCells[5], false);
        CreateElement(bigCell, true);
    }

    private void CreateElement(Cell cell, bool isCanDrag)
    {
        var position = cell.transform.position;
        var element = Instantiate(DataManager.GameData.elementPrefab, elementsParent).GetComponent<Element>();
        elements.Add(element);
        cell.element = element;
        element.isCanDrag = isCanDrag;
        PlaceElement(element, cell);
    }

    private void PlaceElement(Element element, Cell cell)
    {
        foreach (var fieldCell in fieldCells)
        {
            if (fieldCell.element == element)
            {
                fieldCell.element = null;
                break;
            }
        }
        if (bigCell.element == element) bigCell.element = null;
        if (smallCell.element == element) smallCell.element = null;
        PlaceElement(element, cell.transform.position);
        cell.element = element;
    }

    private void PlaceElement(Element element, Vector3 position)
    {
        element.transform.position = position - (Vector3)((element.transform as RectTransform).sizeDelta / 2);
        element.lastPosition = position;
    }

    public void ListenMessage(Message message)
    {
        if (message is SetElementPlaceMessage placeMsg)
        {
            PointerEventData pointerData = new PointerEventData(EventSystem.current);
            List<RaycastResult> resultsData = new List<RaycastResult>();
            pointerData.position = placeMsg.place;
            EventSystem.current.RaycastAll(pointerData, resultsData);
            bool isPlaced = false;
            foreach (var elem in resultsData)
            {
                var cell = elem.gameObject.GetComponent<Cell>();
                if (!cell) continue;
                PlaceElement(placeMsg.element, cell);
                isPlaced = true;
            }
            if (!isPlaced)
            {
                PlaceElement(placeMsg.element, placeMsg.element.lastPosition);
            }
        }
    }
}
