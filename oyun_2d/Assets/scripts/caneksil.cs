using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caneksil : MonoBehaviour
{
    oyuncusaglik Oyuncusaglik;
    private void Awake()
    {
        Oyuncusaglik = Object.FindObjectOfType<oyuncusaglik>();
    }
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Player")
        {
            cani();
            sesolaylari.olay.sesefectcal(6);
        }
    }
    public void cani()
    {
        Oyuncusaglik.canal();
    }
}
