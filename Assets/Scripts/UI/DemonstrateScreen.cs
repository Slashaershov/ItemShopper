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
    [SerializeField] private Image _bigImage;
    [SerializeField] private Image _discountImage;
    [SerializeField] private SpriteConfigs _spriteConfigs;
    [SerializeField] List<MaterialSlotDemonstrator> _slots;
    public override void Show(ItemData itemData)
    {
        _name.text = itemData.Name;
        _description.text = itemData.Description;
        UpdateCost(itemData);
        _bigImage.sprite = GetSprite(itemData.BigSpriteType);
        UpdateSlots(itemData.MaterialNotes);
        base.Show(itemData);
    }

    private void UpdateCost(ItemData itemData)
    {
        if (itemData.Discount != 0)
        {
            SetActiveDiscount(true);
            _discount.text = "-" + itemData.Discount.ToString() + "%";
            _basePrice.text = itemData.BasePrice.ToString();
            _cost.text = itemData.Cost.ToString();

        }
        else
        {
            SetActiveDiscount(false);
            _cost.text ="$" + itemData.Cost.ToString();
        }
    }

    private void SetActiveDiscount(bool state)
    {
        _discount.gameObject.SetActive(state);
        _basePrice.gameObject.SetActive(state);
        _discountImage.gameObject.SetActive(state);
    }

    private void UpdateSlots(List<MaterialNote> notes)
    {
        for (var i=0; i< _slots.Count; i++)
        {
            if (i< notes.Count)
            {
                var note = notes[i];
                _slots[i].SetData(GetSprite(note.SpriteType), note.Count);
            }
            else
            {
                _slots[i].Disable();
            }
        }
    }

    private Sprite GetSprite(MaterialSpriteType type) => _spriteConfigs.GetSprite(type);

    private Sprite GetSprite(BigSpriteType type) => _spriteConfigs.GetSprite(type);
}

