using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bag : MonoBehaviour
{
    [SerializeField] private SpriteRenderer openSprite;
    [SerializeField] private SpriteRenderer closeSprite;

    public UnityEvent openEvent = new UnityEvent();
    public UnityEvent closeEvent = new UnityEvent();

    private bool isOpen = true;
    private void Start()
    {
        if (openEvent == null)
            openEvent = new UnityEvent();
        if (closeEvent == null)
            closeEvent = new UnityEvent();

        Reset();
    }
    public void Open()
    {
        if (!isOpen)
        {
            closeSprite.enabled = false;
            openSprite.enabled = true;
            openEvent.Invoke();
        }
        isOpen = true;
    }
    public void Close()
    {
        if (isOpen)
        {
            closeSprite.enabled = true;
            openSprite.enabled = false;
            closeEvent?.Invoke();
        }
        isOpen = false;
    }
    public void Reset()
    {
        closeSprite.enabled = true;
        openSprite.enabled = false;
        isOpen = false;
    }
}
