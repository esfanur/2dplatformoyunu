using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombaolay : MonoBehaviour
{
    public GameObject patlamaefect;
    caneksil Caneksil;
    private void Awake()
    {
        Caneksil = Object.FindObjectOfType<caneksil>();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            bombafonk();
            Caneksil.cani();
        }
    }
    public void bombafonk()
    {
        Destroy(gameObject);
        Instantiate(patlamaefect, transform.position, transform.rotation);
    }
}
