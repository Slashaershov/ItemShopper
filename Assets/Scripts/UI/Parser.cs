using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class Parser 
{
    public static bool TryParse(string text, out MaterialSpriteType res)
    {
        try
        {
            res = (MaterialSpriteType)System.Enum.Parse(typeof(MaterialSpriteType), text);
            return true;
        }
        catch (FormatException e)
        {
            Debug.LogError($"Parse error: {e}");
            res = MaterialSpriteType.None;
            return false;
        }
    }

    public static bool TryParse(string text, out BigSpriteType res)
    {
        try
        {
            res = (BigSpriteType)System.Enum.Parse(typeof(BigSpriteType), text);
            return true;
        }
        catch (FormatException e)
        {
            Debug.LogError($"Parse error: {e}");
            res = BigSpriteType.None;
            return false;
        }
    }

    public static bool TryParse(string str, out float res)
    {
        try
        {
            res = float.Parse(str);
            return true;
        }
        catch (FormatException e)
        {
            Debug.LogError($"Parse error: {e}");
            res = 1;
            return false;
        }
    }

    public static bool TryParse(string str, out int res)
    {
        try
        {
            res = int.Parse(str);
            return true;
        }
        catch (FormatException e)
        {
            Debug.LogError($"Parse error: {e}");
            res = 1;
            return false;
        }
    }

}
