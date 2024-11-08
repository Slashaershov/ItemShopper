using System.Collections.Generic;
using UnityEngine;
using System;

public class ItemData
{
    public readonly string Name;
    public readonly string Description;
    public readonly List<MaterialNote> MaterialNotes;
    public readonly float BasePrice;
    public readonly int Discount;
    public readonly BigSpriteType BigSpriteType;
    public float Cost => GetCost();


    public ItemData (string name, string description, List<MaterialNote> materialNotes, 
        float basePrice, int discount, BigSpriteType bigSpriteType)
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

public enum MaterialSpriteType
{
    Grass = 1,
    Meat = 2,
    Sand = 3,
    Stone = 4,
    Wood = 5,

    None = 999,
}

public enum BigSpriteType
{
    ConstructionKit = 1,
    BeginnerBuildersKit = 2,
    Balls = 3,
    MoneySuitcase = 4,
    Pizza = 5,

    None = 999,
}

public class MaterialNote
{
    public readonly MaterialSpriteType SpriteType;
    public readonly int Count;

    public MaterialNote(MaterialSpriteType spriteType, int count)
    {
        SpriteType = spriteType;
        Count = count;
    }
}
