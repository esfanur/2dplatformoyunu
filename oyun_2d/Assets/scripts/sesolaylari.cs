using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sesolaylari : MonoBehaviour
{
    public static sesolaylari olay;

    public AudioSource[] sesefectleri;
    private void Awake()
    {
        olay = this;
    }
    
    public void sesefectcal(int hangises)
    {
        sesefectleri[hangises].Stop();
        sesefectleri[hangises].Play();

    }
    public void sesayariylaoynama(int hangises)
    {
        sesefectleri[hangises].Stop();
        sesefectleri[hangises].pitch = Random.Range(0.1f, 2.95f);
        sesefectleri[hangises].Play();

    }
}
