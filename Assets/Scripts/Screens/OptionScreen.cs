using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionScreen : BaseScreen
{
    [SerializeField]
    public void Generate()
    {
        var data = CreateData();
        ScreenController.Instance.ActivateNext(data);
    }

    private ItemData CreateData()
    {
        return new ItemData();
    }
}
