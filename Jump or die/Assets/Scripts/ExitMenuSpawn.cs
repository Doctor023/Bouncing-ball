using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitMenuSpawn : MonoBehaviour
{
    private bool _exitMenuPositionOnScreen = false;

    public bool _ExitMenuPositionOnScreen
    {
        get { return _exitMenuPositionOnScreen; }
        set { _exitMenuPositionOnScreen = value; }
    }

    public void SetPositionOnScreen (bool _newPosition)
    {
        _exitMenuPositionOnScreen = _newPosition;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            switch (_exitMenuPositionOnScreen)
            {
                case false:
                    transform.position = new Vector2(0, 0);
                    _exitMenuPositionOnScreen = true;
                    Time.timeScale = 0;
                    break;
                case true:
                    transform.position = new Vector2(0, -50);
                    _exitMenuPositionOnScreen = false;
                    Time.timeScale = 1;
                    break;
            }
        }

    }
}

