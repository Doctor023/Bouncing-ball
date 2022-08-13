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
        StartCoroutine(TimeToRestart());
        
    }
    private IEnumerator TimeToRestart()
    {
        yield return new WaitForSecondsRealtime(0.2f);
        _timeToRestart = true;
        Debug.Log("Можно рестартнуть"); ;
        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && _timeToRestart)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
