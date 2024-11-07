using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionScreenGenerateButton : BaseButtonEventSystem
{
    [SerializeField] OptionScreen _screen;
    protected override void OnButtonClick()
    {
        _screen.Generate();
    }
}
