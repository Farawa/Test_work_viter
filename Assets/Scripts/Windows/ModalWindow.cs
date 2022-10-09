using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
[RequireComponent(typeof(Button))]
public class ModalWindow : MonoBehaviour
{
    [SerializeField] private ModalType modalType;
    public ModalType ModalType=>modalType;

    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(Close);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }
}
