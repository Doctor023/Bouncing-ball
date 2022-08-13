using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitMenuSpawn : MonoBehaviour
{
    [SerializeField] private bool _exitMenuPositionOnScreen = false;
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            switch (_exitMenuPositionOnScreen)
            {
                case false:
                    Debug.Log("���� ���������");
                    transform.position = new Vector2(0, 0);
                    _exitMenuPositionOnScreen = true;
                    break;
                case true:
                    Debug.Log("���� ���������");
                    transform.position = new Vector2(0, -50);
                    _exitMenuPositionOnScreen = false;
                    break;
            }
        }

    }
}

