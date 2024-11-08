using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using System;

public class BasePriseInputField : MonoBehaviour
{
    [SerializeField] private TMP_InputField _inputField;
    private void Start()
    {
        _inputField.onEndEdit.AddListener(CutValue);
    }

    private void CutValue(string text)
    {
        decimal resValue = 0;
        if (text.Length != 0)
        {
            resValue = decimal.Parse(text);
            resValue =Math.Round(resValue, 2);
        }
        _inputField.text = resValue.ToString();
    }
}
