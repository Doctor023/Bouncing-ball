using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class RestartFromMenu : MonoBehaviour
{
    private bool _timeToRestart = false;
    private void Start()
    {
        Debug.Log("����� ����������");
        Invoke("TimeToRestart", 2.0f);
    }
    void TimeToRestart()
    {
        _timeToRestart = true;
        Debug.Log("����� �����������");
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && _timeToRestart)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
