using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private int _playerPosition;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _jumpForce;


 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out WallDown walldown))
        {
            _playerPosition = -1;
        }
        else if (collision.collider.TryGetComponent(out WallUp wallup))
        {
            _playerPosition = 1;
        }
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out WallDown walldown) || collision.collider.TryGetComponent(out WallUp wallup))
        {
            _playerPosition = 0;          
        }
    }
    void Update()
    {       
 
            if (Input.GetKeyDown(KeyCode.Space))
            {
                switch (_playerPosition)
                {
                    case -1:
                        _rigidbody2D.AddForce(Vector2.up * _jumpForce);
                        break;
                    case 1:
                        _rigidbody2D.AddForce(Vector2.down * _jumpForce);
                        break;
                }
            }
        }
    }
