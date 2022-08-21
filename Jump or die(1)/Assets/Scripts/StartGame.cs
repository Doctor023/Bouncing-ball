using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartGame : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _startText;
    [SerializeField] private GameObject _player;

    void Start()
    {
        Time.timeScale = 0;

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Escape))
        {
            Time.timeScale = 1;
            Destroy(_startText);
            _player.GetComponent<Jump>().enabled = true;
            enabled = false;
        }
    }
}
