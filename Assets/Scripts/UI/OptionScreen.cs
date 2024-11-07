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
    [SerializeField] private TMP_InputField _cost;
    [SerializeField] private Slider _discount;
    [SerializeField] private MaterialSlotsView _materials;

    public void Generate()
    {
        ItemData data;
        if (TryCreateData(out data))
        {
            ScreenController.Instance.ActivateNext(data);
        }
        else
        {
            Debug.LogError("Input data error");
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
        SpriteType bigSprite;
        if (!TryGetSpriteType(_bigSprite.itemText.text, out bigSprite))
        {
            return false;
        }
        
        var materials = GetMaterialNotes();
        data = new ItemData(_name.text, _description.text, materials, cost, (int)_discount.value, bigSprite);
        return true;
    }

    private bool TryGetCost(out float cost)
    {
        return TryParseStringToFloat(_cost.text, out cost) && cost > 0;
    }

    private bool TryParseStringToFloat(string str, out float res)
    {
        try
        {
            res = float.Parse(str);
            return true;
        }
        catch (FormatException e)
        {
            Debug.LogError($"Parse error: {e}");
            res = 1;
            return false;
        }
    }

    private bool TryGetSpriteType(string text, out SpriteType res)
    {
        try
        {
            res = (SpriteType)System.Enum.Parse(typeof(SpriteType), text);
            return true;
        }
        catch (FormatException e)
        {
            Debug.LogError($"Parse error: {e}");
            res = SpriteType.Sand;
            return false;
        }
    }

    private List<MaterialNotes> GetMaterialNotes()
    {
        return new List<MaterialNotes>();
    }
}
