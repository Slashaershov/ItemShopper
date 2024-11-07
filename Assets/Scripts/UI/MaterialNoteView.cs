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
    private const int BaseCountValue = 10;
    public void Init(int index)
    {
        _slotName.text = "Slot " + (index+1).ToString();
        _count.text = BaseCountValue.ToString();
    }
}

