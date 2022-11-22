using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kirazkod : MonoBehaviour
{
    bool toplandimi;
    oyuncusaglik Oyuncusaglik;
    [SerializeField]
    GameObject toplamaefect;
    private void Awake()
    {
        Oyuncusaglik = Object.FindObjectOfType<oyuncusaglik>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Player"&& !toplandimi)
        {
            
            if(Oyuncusaglik.gecerlisaglik!=Oyuncusaglik.Maksaglik)
            {
                Oyuncusaglik.canartir();
                toplandimi = true;
                Destroy(gameObject);
                Instantiate(toplamaefect, transform.position, transform.rotation);
                sesolaylari.olay.sesefectcal(4);
            }
            
        }
    }
}
