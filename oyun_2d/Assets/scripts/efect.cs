using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class efect : MonoBehaviour
{
    [SerializeField]
    float efectsuresi;
    private void Start()
    {
        Destroy(gameObject, efectsuresi);
    }
}
