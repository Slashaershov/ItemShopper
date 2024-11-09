using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class FinalCost : MonoBehaviour
{
    [SerializeField] private Slider _discount;
    [SerializeField] private TMP_InputField _price;
    [SerializeField] private TMP_Text _text;
    private void Start()
    {
        _discount.onValueChanged.AddListener(UpdateCost);
        _price.onEndEdit.AddListener(UpdateCost);
        UpdateCost(_discount.value);
    }

    public float CalculateCost()
    {
        float price;
        if (Parser.TryParse(_price.text, out price))
        {
            return ItemData.CalcCost(price, (int)_discount.value);
        }
        else
        {
            throw new Exception("Input exception");
        }
    }
    private void UpdateCost(string text)
    {
        UpdateCost();
    }

    private void UpdateCost(float newValue)
    {
        UpdateCost();
    }

    private void UpdateCost()
    {
        _text.text = CalculateCost().ToString();
    }


}
