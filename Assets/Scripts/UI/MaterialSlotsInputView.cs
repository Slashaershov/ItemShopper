using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaterialSlotsInputView : MonoBehaviour
{
    [SerializeField] private List<MaterialNoteView> _slots;
    [SerializeField] private Slider _slider;

    public bool TryGetData(out List<MaterialNote> result)
    {
        result = new List<MaterialNote>();
        foreach (var slot in _slots)
        {
            if (slot.gameObject.activeSelf)
            {
                MaterialNote newItem;
                if (!slot.TryGetInfo(out newItem))
                {
                    return false;
                }
                result.Add(newItem);
            }
        }
        return true;
    }

    private void Start()
    {
        _slider.onValueChanged.AddListener(OnSliderValueChanged);
        OnSliderValueChanged(_slider.value);
        InitSlots();
    }

    private void InitSlots()
    {
        for (var i = 0; i < _slots.Count; i++)
        {
            _slots[i].Init(i);
        }
    }

    private void OnSliderValueChanged(float newValue)
    {
        for (var i=0; i< _slots.Count; i++)
        {
            _slots[i].gameObject.SetActive(i < newValue);
        }
    }
}
