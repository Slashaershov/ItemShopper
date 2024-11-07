using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class DropDownBySpriteEnumFiller : MonoBehaviour
{
    [SerializeField] private Dropdown _dropDown;

    private void Start()
    {
        FillDropDown();
    }

    private void FillDropDown()
    {
        var enumValues = Enum.GetValues(typeof(SpriteType));
        foreach (var x in enumValues)
        {
            _dropDown.options.Add(new Dropdown.OptionData(x.ToString()));
        }
    }
}
