using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ExitClickFalse : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject _exitMenu;
    public bool _exitMenuPositionOnScreen;
    

    //private bool _exitMenuPositionOnScreen = _exitMenu.GetComponent<ExitMenuSpawn>()._exitMenuPositionOnScreen;

    void Start()
    {
        
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        
        _exitMenuPositionOnScreen = _exitMenu.GetComponent<ExitMenuSpawn>()._ExitMenuPositionOnScreen;
        var ExitMenuSpawn = _exitMenu.GetComponent<ExitMenuSpawn>();

        if (_exitMenuPositionOnScreen)
        {
            _exitMenu.transform.position = new Vector2(0, -50);
            ExitMenuSpawn.SetPositionOnScreen(false);
        }
    }

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
    }
}
