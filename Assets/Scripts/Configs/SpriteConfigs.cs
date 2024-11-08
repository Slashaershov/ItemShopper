using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


[CreateAssetMenu(menuName = "Configs/SpriteConfigs", fileName = "SpriteConfigs")]

public class SpriteConfigs : ScriptableObject
{
    [SerializeField] private SpriteConfig<BigSpriteType> _bigSpriteNotes;
    [SerializeField] private SpriteConfig<MaterialSpriteType> _materialSpriteNotes;
    public Sprite GetSprite(BigSpriteType type)
    {
        return _bigSpriteNotes.GetSprite(type);
    }

    public Sprite GetSprite(MaterialSpriteType type)
    {
        return _materialSpriteNotes.GetSprite(type);
    }
}
