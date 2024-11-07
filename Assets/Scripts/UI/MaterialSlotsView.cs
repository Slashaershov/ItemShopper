using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaterialSlotsView : MonoBehaviour
{
    [SerializeField] private List<MaterialNoteView> _slots;
    [SerializeField] private Slider _slider;

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
