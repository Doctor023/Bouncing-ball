using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ExitMouseTrue : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Transform _true;

    public void OnPointerEnter(PointerEventData eventData)
    {
        _true.localScale = new Vector2(5, 5);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _true.localScale = new Vector3(4.646991f, 4.635598f);
    }
}
