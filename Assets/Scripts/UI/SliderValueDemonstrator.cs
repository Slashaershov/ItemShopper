using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SliderValueDemonstrator : MonoBehaviour
{
    [SerializeField] private TMP_Text _textMesh;
    [SerializeField] private Slider _slider;

    private void Start()
    {
        _slider.onValueChanged.AddListener(OnSliderValueChanged);
        OnSliderValueChanged(_slider.value);
    }

    private void OnSliderValueChanged(float newValue)
    {
        _textMesh.text = newValue.ToString();
    }

}
