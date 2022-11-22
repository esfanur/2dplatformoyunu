using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kurbagayoket : MonoBehaviour
{
    [SerializeField]
    GameObject yokolmaefect;
    hareket Hareket;
    public float cansansi;
    public GameObject kiraz;
    private void Awake()
    {
        Hareket = Object.FindObjectOfType<hareket>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="kurbaga")
        {
            collision.transform.parent.gameObject.SetActive(false);
            Instantiate(yokolmaefect, transform.position, transform.rotation);
            Hareket.kurbagazipla();
            float cikmasansi = Random.Range(0f, 100f);

            sesolaylari.olay.sesefectcal(0);
            if(cikmasansi<cansansi)
            {
                Instantiate(kiraz, collision.transform.position, collision.transform.rotation);
            }
        }
    }
}
