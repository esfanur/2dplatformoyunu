using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankzarar : MonoBehaviour
{
    tankhareket Tankhareket;
    hareket oyuncuhareket;

    private void Awake()
    {
        Tankhareket = Object.FindObjectOfType<tankhareket>();
        oyuncuhareket = Object.FindObjectOfType<hareket>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player" && oyuncuhareket.transform.position.y>transform.position.y)
        {
            Tankhareket.darbealfnk();
        }
    }
}
