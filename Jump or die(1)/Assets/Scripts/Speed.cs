using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    [SerializeField] private int _speedPoint;
    [SerializeField] private int _speed;

    public int _Speed { get { return _speed; } }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out GoodBlock goodBlock))
        {
            _speedPoint++;
            if (_speedPoint == 3)
            {
                _speed = _speed + 2;               
                _speedPoint = 0;
                
            }
        }
    }
}

