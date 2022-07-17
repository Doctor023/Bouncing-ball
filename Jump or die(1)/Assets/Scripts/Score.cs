using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private int _score;
    [SerializeField] private TextMeshProUGUI _textScore;
    
        private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out GoodBlock goodBlock))
        {
            _score++;
            _textScore.text = "Score: " + _score.ToString();
        }
    }
}
