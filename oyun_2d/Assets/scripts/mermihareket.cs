using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mermihareket : MonoBehaviour
{
    public float mermihizi;

    caneksil Caneksil;
    private void Awake()
    {
        Caneksil = Object.FindObjectOfType<caneksil>();
    }
    private void Update()
    {
        transform.position += new Vector3(-mermihizi * transform.localScale.x * Time.deltaTime, 0f, 0f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            Caneksil.cani();
            print("degdi");
           // Oyuncusaglik.canal();
           

        }
        Destroy(gameObject);

    }
}
