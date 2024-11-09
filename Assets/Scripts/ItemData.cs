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
    public float Cost => CalcCost(BasePrice, Discount);

    public static float CalcCost(float price, int discount)
    {
        var res = price * (100 - discount) / 100;
        res = (float)Math.Round(res, 2);
        return res;
    }
}

public enum MaterialSpriteType
{
    Grass = 1,
    Meat = 2,
    Coal = 3,
    Stone = 4,
    None = 999,
}

public enum BigSpriteType
{
    ConstructionKit = 1,
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
