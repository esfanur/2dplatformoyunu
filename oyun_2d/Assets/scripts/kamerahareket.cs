using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamerahareket : MonoBehaviour
{
    [SerializeField]
    Transform oyuncutransform;
    [SerializeField]
    float min, mak;

    Vector2 sonpos;
    [SerializeField]
    Transform altzemin, ustzemin;
    private void Start()
    {
        sonpos = transform.position;
    }
    void Update()
    {
        kamerasinirlari();
        arkaplanhareket();
    }
    void kamerasinirlari()
    {
        transform.position = new Vector3(oyuncutransform.position.x,
             Mathf.Clamp(oyuncutransform.position.y, min, mak),
             transform.position.z);
    }
    void arkaplanhareket()
    {
        Vector2 aradakiposfak = new Vector2(transform.position.x - sonpos.x, transform.position.y - sonpos.y);

        altzemin.position += new Vector3(aradakiposfak.x, aradakiposfak.y,0);
        ustzemin.position += new Vector3(aradakiposfak.x, aradakiposfak.y,0) * .4f;
        sonpos = transform.position;
    }
}
