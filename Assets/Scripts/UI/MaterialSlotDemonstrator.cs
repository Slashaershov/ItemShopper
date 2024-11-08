using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class MaterialSlotDemonstrator : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private TMP_Text _count;
    public void Disable()
    {
        gameObject.SetActive(false);
    }

    public void Enable()
    {
        gameObject.SetActive(true);
    }

    public void SetData(Sprite sprite, int cout)
    {
        _count.text = cout.ToString();
        _image.sprite = sprite;
    }
}
