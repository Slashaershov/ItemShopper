using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class DemonstrateScreen : BaseScreen
{
    [SerializeField] private TMP_Text _name;
    [SerializeField] private TMP_Text _description;
    [SerializeField] private Text _basePrice;
    [SerializeField] private Text _discount;
    [SerializeField] private Text _cost;
    //[SerializeField] private List<> _name;
    [SerializeField] private Image _bigImage;
    public override void Show(ItemData itemData)
    {
        _name.text = itemData.Name;
        _description.text = itemData.Description;
        _basePrice.text = itemData.BasePrice.ToString();
        _discount.text = itemData.Discount.ToString();
        _cost.text = itemData.Cost.ToString();
        base.Show(itemData);
    }
}

