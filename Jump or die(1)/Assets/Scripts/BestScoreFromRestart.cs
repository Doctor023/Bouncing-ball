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
        var _bestScore = _player.GetComponent<Score>()._BestScore;
        _bestScoreGameOverMenu.text = "Best: " + _bestScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
