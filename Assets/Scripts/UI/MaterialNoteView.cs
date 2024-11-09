using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class MaterialNoteView : MonoBehaviour
{
    [SerializeField] TMP_Text _slotName;
    [SerializeField] private TMP_InputField _count;
    [SerializeField] private Dropdown _dropDown;
    private const int BaseCountValue = 10;
    public void Init(int index)
    {
        _slotName.text = "Slot " + (index+1).ToString();
        _count.text = BaseCountValue.ToString();
    }


    public bool TryGetInfo(out MaterialNote result)
    {
        result = null;
        int count = 0;
        if (!TryGetValue(out count))
        {
            return false;
        }
        MaterialSpriteType spriteType = MaterialSpriteType.None;
        if (!TryGetMaterialSpriteType(out spriteType))
        {
            return false;
        }
        result = new MaterialNote(spriteType, count);
        return true;
    }

    private bool TryGetValue(out int res)
    {
        return Parser.TryParse(_count.text, out res) && res> 0;
    }

    private bool TryGetMaterialSpriteType(out MaterialSpriteType res)
    {
        return Parser.TryParse(_dropDown.options[_dropDown.value].text, out res);
    }
}



