using System.Collections.Generic;
using UnityEngine;

public class ItemData
{
    public readonly string Name;
    public readonly string Description;
    public readonly List<MaterialNotes> MaterialNotes;
    public readonly int Cost;
    public readonly int Discount;
    public readonly SpriteType BigSpriteType;

    public ItemData()
    {
        Name = "";
        Description = "";
        MaterialNotes = null;
        Cost = 0;
        Discount = 0;
    }

    public ItemData (string name, string description, List<MaterialNotes> materialNotes, 
        int cost, int discount, SpriteType bigSpriteType)
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