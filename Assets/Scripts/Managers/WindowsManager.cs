using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowsManager : MonoBehaviour
{
    [SerializeField] private Transform parentForWindows;
    private static List<Window> windows = new List<Window>();

    private void Awake()
    {
        if (windows.Count != 0)
        {
            for(int i = windows.Count - 1; i >= 0; i--)
            {
                Destroy(windows[i].gameObject);
            }
            windows.Clear();
        }
        var windowsPrefabs = DataManager.GameData.windowPrefabs;
        for(int i = 0; i < windowsPrefabs.Length; i++)
        {
            var window = Instantiate(windowsPrefabs[i], parentForWindows).GetComponent<Window>();
            windows.Add(window);
            window.gameObject.SetActive(false);
        }
    }

    public static void SetWindow(WindowType windowType)
    {
        foreach(var win in windows)
        {
            if(windowType == win.GetWindowType())
            {
                win.gameObject.SetActive(true);
                win.Enable();
            }
            else
            {
                win.Disable();
                win.gameObject.SetActive(false);
            }
        }
    }
}

public enum WindowType
{
    main,
    game
}
