using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out Destroy destroy))
        {
            Debug.Log("������ �����������");
            Destroy(gameObject);
       }
    }
}
