using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toplananelmas : MonoBehaviour
{
    levelmangecer Levelmagacer;
    kalpdegsim uicontroller;
    bool toplandimi;
    [SerializeField]
    GameObject toplamaefect;
    private void Awake()
    {
        uicontroller = Object.FindObjectOfType<kalpdegsim>();
        Levelmagacer = Object.FindObjectOfType<levelmangecer>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Player" && !toplandimi)
        {
            Levelmagacer.toplananelmassayisi++;
            toplandimi = true;
            Destroy(gameObject);
            uicontroller.elmassayisi();
            Instantiate(toplamaefect, transform.position, transform.rotation);
            sesolaylari.olay.sesayariylaoynama(7);

        }
    }
}
