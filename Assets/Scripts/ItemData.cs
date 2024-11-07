using System.Collections.Generic;
using UnityEngine;
using System;

public class ItemData
{
    public readonly string Name;
    public readonly string Description;
    public readonly List<MaterialNotes> MaterialNotes;
    public readonly float BasePrice;
    public readonly int Discount;
    public readonly SpriteType BigSpriteType;
    public float Cost => GetCost();


    public ItemData (string name, string description, List<MaterialNotes> materialNotes, 
        float basePrice, int discount, SpriteType bigSpriteType)
    {
        Name = name;
        Description = description;
        MaterialNotes = materialNotes;
        BasePrice = basePrice;
        Discount = discount;
        BigSpriteType = bigSpriteType;
    }

    private float GetCost()
    {
        var res = BasePrice * (100 - Discount) / 100;
        res = (float)Math.Round(res, 2);
        return res;
    }
}

public enum SpriteType
{
    Wood = 1,
    Tears = 2,
    Sand = 3,
}

public class MaterialNotes
{
    public readonly SpriteType SpriteType;
    public readonly int Count;

    public MaterialNotes(SpriteType spriteType, int count)
    {
        SpriteType = spriteType;
        Count = count;
    }
}
