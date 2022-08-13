using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ExitClickFalse : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject _exitMenu;
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Клик");
        _exitMenu.transform.position = new Vector2(0, -50);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
