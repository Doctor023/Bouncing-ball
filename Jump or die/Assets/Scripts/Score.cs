using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private int _score;
    [SerializeField] private TextMeshProUGUI _textScore;
    [SerializeField] private int _bestScore;
    [SerializeField] private TextMeshProUGUI _textBestScore;

    public int BestScore
    {
        get { return _bestScore; }
        set { _bestScore = value; }
    }

    public void Start()
    {
        _bestScore = PlayerPrefs.GetInt("Best Score");
        _textBestScore.text = "Best Score: " + _bestScore.ToString();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out GoodBlock goodBlock))
        {
            _score++;
            _textScore.text = "Score: " + _score.ToString();
            if (_bestScore < _score)
            {
                _bestScore = _score;
                _textBestScore.text = "Best Score: " + _bestScore.ToString();
            }
        }
    }

    }

