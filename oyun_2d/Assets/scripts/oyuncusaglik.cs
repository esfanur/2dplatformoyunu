using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class oyuncusaglik : MonoBehaviour
{
    public int Maksaglik, gecerlisaglik;

    kalpdegsim Kalpdegisim;
    public int yenilmezliksure;
    float yenilmezliksayac;

    [SerializeField]
    GameObject yokolmaefect;
    SpriteRenderer sr;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        Kalpdegisim = Object.FindObjectOfType<kalpdegsim>();
    }

    // Start is called before the first frame update
    void Start()
    {
        gecerlisaglik = Maksaglik;
    }
    private void Update()
    {
       yenilmezliksayac -= Time.deltaTime;
        if(yenilmezliksayac<=0)
             sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, 1f);
    }
    public void canal()
    {
        if(yenilmezliksayac<=0)
        {
            gecerlisaglik--;
            if (gecerlisaglik <= 0)
            {
                
                Instantiate(yokolmaefect, transform.position, transform.rotation);
                gameObject.SetActive(false);
                sesolaylari.olay.sesefectcal(2);
            }

            else
            {
                yenilmezliksayac = yenilmezliksure;
                sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, 0.5f);
                sesolaylari.olay.sesefectcal(1);

            }

            Kalpdegisim.salikdurumgncel();
        }
       
        
    }
    public void canartir()
    {
        gecerlisaglik++;
        if (gecerlisaglik >= Maksaglik)
            gecerlisaglik = Maksaglik;
        Kalpdegisim.salikdurumgncel();
    }

}
