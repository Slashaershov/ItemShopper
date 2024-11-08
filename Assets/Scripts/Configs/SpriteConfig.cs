using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[Serializable]
public class SpriteConfig<T>  where T:Enum
{
    [SerializeField] private List<SpriteNote<T>> _notes;
    private Dictionary<T, Sprite> _dictionary;
    public Sprite GetSprite(T type)
    {
        if (_dictionary == null)
        {
            Init();
        }
        if (!_dictionary.ContainsKey(type))
        {
            throw new Exception($"Config haven't got note: {type}");
        }
        return _dictionary[type];
    }

    private void Init()
    {
        _dictionary = new Dictionary<T, Sprite>();
        foreach (var note in _notes)
        {
            if (_dictionary.ContainsKey(note.SpriteType))
            {
                throw new Exception("Notes contain duplicates");
            }
            _dictionary.Add(note.SpriteType, note.Sprite);
        }
    }
}

[Serializable]
public class SpriteNote<T> where T : Enum
{
    [SerializeField] private T _spriteType;
    public T SpriteType => _spriteType;
    [SerializeField] private Sprite _sprite;
    public Sprite Sprite => _sprite;
}