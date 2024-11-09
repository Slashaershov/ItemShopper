using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public abstract class DropDownBySpriteEnumFiller<T> : MonoBehaviour where T : Enum
{
    [SerializeField] private Dropdown _dropDown;

    private void Start()
    {
        FillDropDown();
    }

    private void FillDropDown()
    {
        var enumValues = Enum.GetValues(typeof(T));
        foreach (var x in enumValues)
        {
            _dropDown.options.Add(new Dropdown.OptionData(x.ToString()));
        }
        _dropDown.value = 0;
        _dropDown.captionText.text = _dropDown.options[_dropDown.value].text;
    }
}
