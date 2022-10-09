using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class SetModalButton : MonoBehaviour
{
    [SerializeField] private ModalType targetModalType;

    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(Click);
    }

    private void Click()
    {
        MessagesManager.SendMessage(new SetModalMessage(targetModalType));
    }
}
