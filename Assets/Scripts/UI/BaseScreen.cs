using System.Collections;
using UnityEngine;

public class BaseScreen : MonoBehaviour
{
    [SerializeField] public ScreenType ScreenType { get; private set; }
    public virtual void Show(ItemData ItemData)
    {
        Show();
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}