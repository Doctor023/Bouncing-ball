using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class RestartFromMenu : MonoBehaviour
{
    [SerializeField] private GameObject _exitMenu;

    private bool _timeToRestart = false;
    private void Start()
    {
        _exitMenu = GameObject.FindGameObjectWithTag("ExitMenu");
        var _exitMenuSpawn = _exitMenu.GetComponent<ExitMenuSpawn>();
        _exitMenuSpawn.enabled = false;
        StartCoroutine(TimeToRestart());
    }
    private IEnumerator TimeToRestart()
    {
        yield return new WaitForSecondsRealtime(0.2f);
        _timeToRestart = true;
        
    }
    void Update()
    {
        if ((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Escape) && _timeToRestart))
        {
            _exitMenu = GameObject.FindGameObjectWithTag("ExitMenu");
            var _exitMenuSpawn = _exitMenu.GetComponent<ExitMenuSpawn>();
            _exitMenuSpawn.enabled = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
