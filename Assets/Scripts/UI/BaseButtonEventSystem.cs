using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseButtonEventSystem : MonoBehaviour
{
    [SerializeField] private Button _button;

    protected abstract void OnButtonClick();

    private void Start()
    {
        _button.onClick.AddListener(OnButtonClick);
    }
}
