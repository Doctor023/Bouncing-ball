using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpeed : MonoBehaviour
{
    [SerializeField] private GameObject Player;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    private void FixedUpdate()
    {
        
        var _speed = Player.GetComponent<Speed>()._Speed;      
        transform.Translate(new Vector2(-1, 0).normalized * _speed * Time.deltaTime);
    }
}
