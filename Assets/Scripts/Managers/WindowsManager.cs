using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowsManager : MonoBehaviour
{
    [SerializeField] private Transform parentForWindows;
    [SerializeField] private Transform parentForModals;

    private static List<Window> windows = new List<Window>();
    private static List<ModalWindow> modalWindows = new List<ModalWindow>();

    private void Awake()
    {
        CreateWindows();
    }

    private void CreateWindows()
    {
        if (windows.Count != 0)
        {
            for (int i = windows.Count - 1; i >= 0; i--)
            {
                Destroy(windows[i].gameObject);
            }
            windows.Clear();
        }
        var windowsPrefabs = DataManager.GameData.windowPrefabs;
        foreach (var win in windowsPrefabs)
        {
            var window = Instantiate(win, parentForWindows).GetComponent<Window>();
            windows.Add(window);
            window.gameObject.SetActive(false);
        }
        var modalsPrefabs = DataManager.GameData.modalWindows;
        foreach(var mod in modalsPrefabs)
        {
            var modal = Instantiate(mod, parentForModals).GetComponent<ModalWindow>();
            modalWindows.Add(modal);
            modal.Close();
        }
    }

    public static void SetWindow(WindowType windowType)
    {
        foreach(var win in windows)
        {
            if(windowType == win.GetWindowType())
            {
                win.Enable();
                win.gameObject.SetActive(true);
            }
            else
            {
                win.Disable();
                win.gameObject.SetActive(false);
            }
        }
    }

    public static void SetModal(ModalType modalType)
    {
        foreach(var mod in modalWindows)
        {
            if(modalType == mod.ModalType)
            {
                mod.gameObject.SetActive(true);
            }
            else
            {
                mod.Close();
            }
        }
    }
}

public enum WindowType
{
    main,
    game
}

public enum ModalType
{
    win,
    lose,
    sound
}