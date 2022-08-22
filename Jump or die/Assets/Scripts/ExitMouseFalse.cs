using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ExitMouseFalse : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Transform _false;

    public void OnPointerEnter(PointerEventData eventData)
    {
        _false.localScale = new Vector2(5, 5);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _false.localScale = new Vector2(4.358611f, 4.347899f);
    }
}
