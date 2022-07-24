using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject GameOverMenu;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out Block block)) 
        {
            Time.timeScale = 0;
            Instantiate(GameOverMenu, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
}
