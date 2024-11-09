using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenController : MonoBehaviour
{
    [SerializeField] private List<BaseScreen> _screenNotes;
    private int _activeScreenIndex;
    public static ScreenController Instance { get; private set; }
    public void ActivateNext(ItemData data = null)
    {
        _screenNotes[_activeScreenIndex].Hide();
        _activeScreenIndex = (_activeScreenIndex+1)% _screenNotes.Count;
        _screenNotes[_activeScreenIndex].Show(data);
    }

    private void Awake()
    {
        Instance = this;
    }
}


public enum ScreenType
{
    Start = 1,
    Option = 2,
    ItemShow = 3
}
