using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelmangecer : MonoBehaviour
{
    public int toplananelmassayisi;
    public static levelmangecer olaylar;
    hareket Hareket;
    kalpdegsim siyahek;
    //public GameObject oyuncu;
    
    private void Awake()
    {
        olaylar = this;
        Hareket = Object.FindObjectOfType<hareket>();
        siyahek = Object.FindObjectOfType<kalpdegsim>();
    }
    public void sahneyibitir()
    {
        StartCoroutine(sahnebitissureli());
    }
    IEnumerator sahnebitissureli()
    {
        yield return new WaitForSeconds(1f);
        Hareket.hareketesinmi = false;

        yield return new WaitForSeconds(1f);
        siyahek.siyahekran();
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("anamenu");


    }
}
