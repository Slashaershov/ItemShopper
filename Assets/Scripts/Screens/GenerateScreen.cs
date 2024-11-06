using System.Collections;
using UnityEngine;

public class GenerateScreen : BaseScreen
{
    public void Generate()
    {
        ScreenController.Instance.ActivateNext();
    }
}