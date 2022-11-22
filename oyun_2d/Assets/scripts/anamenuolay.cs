using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;//dotwen kullanabilmek için yukledýk
public class anamenuolay : MonoBehaviour
{
    public GameObject resimyazi;
    public GameObject baslamabtn, cikisbtn;
    public GameObject sahnegecisi;

    private void Start()
    {
        StartCoroutine(siraylacil());
    }
    public void oyunabasla()
    {
        StartCoroutine(sahnegec());
    }

 
    IEnumerator siraylacil()
    {
        yield return new WaitForSeconds(.4f);
        resimyazi.GetComponent<CanvasGroup>().DOFade(1, 0.5f);
        yield return new WaitForSeconds(.6f);
        baslamabtn.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(.6f);
        cikisbtn.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutBack);

    }
  
    public void oyundancik()
    {
        Application.Quit();
    }
    IEnumerator sahnegec()
    {
        yield return new WaitForSeconds(.5f);
        sahnegecisi.GetComponent<CanvasGroup>().DOFade(1, 1f);

        yield return new WaitForSeconds(0.85f);
        SceneManager.LoadScene("oyunsahne");
    }
}
