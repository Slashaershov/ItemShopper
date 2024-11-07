using System.Collections.Generic;
using UnityEngine;

public class ItemData
{
    public readonly string Name;
    public readonly string Description;
    public readonly List<MaterialNotes> MaterialNotes;
    public readonly float Cost;
    public readonly int Discount;
    public readonly SpriteType BigSpriteType;

    public ItemData (string name, string description, List<MaterialNotes> materialNotes, 
        float cost, int discount, SpriteType bigSpriteType)
    {
        Name = name;
        Description = description;
        MaterialNotes = materialNotes;
        Cost = cost;
        Discount = discount;
        BigSpriteType = bigSpriteType;
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
