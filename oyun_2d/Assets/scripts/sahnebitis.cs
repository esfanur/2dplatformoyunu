using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sahnebitis : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            levelmangecer.olaylar.sahneyibitir();
        }
    }
}
