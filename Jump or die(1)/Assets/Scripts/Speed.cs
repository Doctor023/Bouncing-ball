using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    [SerializeField] private int _speedPoint;
    [SerializeField] private float _speed;

    public float _Speed { get { return _speed; } }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out GoodBlock goodBlock))
        {
            _speedPoint++;
            if (_speedPoint == 4 && _speed != 32)
            {
                _speed = _speed + 0.5f;               
                _speedPoint = 0;
                
            }
        }
    }
}

