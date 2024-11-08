using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class OptionScreen : BaseScreen
{
    [SerializeField] private TMP_InputField _name;
    [SerializeField] private Dropdown _bigSprite;
    [SerializeField] private TMP_InputField _description;
    [SerializeField] private TMP_InputField _basePrice;
    [SerializeField] private Slider _discount;
    [SerializeField] private MaterialSlotsInputView _materials;

    public void Generate()
    {
        ItemData data;
        if (TryCreateData(out data))
        {
            ScreenController.Instance.ActivateNext(data);
        }
        else
        {
            throw new Exception("Input data error");
        }
    }

    private bool TryCreateData(out ItemData data)
    {
        data = null;
        float cost;
        if (!TryGetCost(out cost))
        {
            return false;
        }
        BigSpriteType bigSprite;
        if (!TryGetBigSpriteType(out bigSprite))
        {
            return false;
        }

        List<MaterialNote> materials;
        if (!TryMaterialNotes(out materials))
        {
            return false;
        }
        data = new ItemData(_name.text, _description.text, materials, cost, (int)_discount.value, bigSprite);
        return true;
    }

    private bool TryGetCost(out float cost)
    {
        return Parser.TryParse(_basePrice.text, out cost) && cost >= 0;
    }

    private bool TryGetBigSpriteType(out BigSpriteType spriteType)
    {
        return Parser.TryParse(_bigSprite.options[_bigSprite.value].text, out spriteType);
    }

    private bool TryMaterialNotes(out List<MaterialNote> result)
    {
        return _materials.TryGetData(out result);
    }
}
