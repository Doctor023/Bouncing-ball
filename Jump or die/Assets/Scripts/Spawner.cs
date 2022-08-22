using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject Block;

    private int _randomSpawn;
    
    private void Start()
    {
        
            StartCoroutine(Spawn());
        
    }
    private IEnumerator Spawn()
    {
        while (true)
        {
            _randomSpawn = Random.Range(0, 2);
            switch (_randomSpawn)
            {
                case 0:
                    Instantiate(Block, new Vector3(13.075f, Random.Range(-5.5f, -2.231f), 0), Quaternion.identity);
                    break;
                case 1:
                    Instantiate(Block, new Vector3(13.075f, Random.Range(2.274f, 5.62f), 0), Quaternion.identity);
                    break;
            }

            yield return new WaitForSeconds(Random.Range(0.5f, 0.7f));
        }
    }
}
