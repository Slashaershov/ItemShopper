using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowScreenBuyButton : BaseButtonEventSystem
{
    [SerializeField] DemonstrateScreen _screen;
    protected override void OnButtonClick()
    {
        _screen.OnBuyButtonClick();
    }
}
