using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
[RequireComponent(typeof(Button))]
public class ModalWindow : MonoBehaviour
{
    [SerializeField] private ModalType modalType;
    [SerializeField] private bool isNeedCloseOnClick = true;
    public ModalType ModalType => modalType;

    private void Awake()
    {
        if (isNeedCloseOnClick)
            GetComponent<Button>().onClick.AddListener(Close);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }
}
