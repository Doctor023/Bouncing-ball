using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BestScoreFromRestart : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _bestScoreGameOverMenu;
    [SerializeField] private GameObject _player;
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        var bestScore = _player.GetComponent<Score>().BestScore;
        PlayerPrefs.SetInt("Best Score", bestScore);
        _bestScoreGameOverMenu.text = "Best: " + bestScore.ToString();
        Debug.Log("BestScoreFromRestart: _bestScore == " + bestScore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
