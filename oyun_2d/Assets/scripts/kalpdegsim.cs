using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
public class kalpdegsim : MonoBehaviour
{
    [SerializeField]
    Image can1,can2, can3;
    // Start is called before the first frame update
    [SerializeField]
    Sprite dolukalp, yarmkalp, boskalp;
    
    public TMP_Text elmastxt;
    public GameObject sahnebit;

    oyuncusaglik Oyuncu;
    levelmangecer Levelmangacer;
    private void Awake()
    {
        
        Levelmangacer = Object.FindObjectOfType<levelmangecer>();
        Oyuncu = Object.FindObjectOfType<oyuncusaglik>();
    }
    public void salikdurumgncel()
    {
        switch(Oyuncu.gecerlisaglik)
        {
            case 6:
                can1.sprite = dolukalp;
                can2.sprite = dolukalp;
                can3.sprite = dolukalp;
                break;

            case 5:
                can1.sprite = dolukalp;
                can2.sprite = dolukalp;
                can3.sprite = yarmkalp;
                break;

            case 4:
                can1.sprite = dolukalp;
                can2.sprite = dolukalp;
                can3.sprite = boskalp;
                break;
            case 3:
                can1.sprite = dolukalp;
                can2.sprite = yarmkalp;
                can3.sprite = boskalp;
                break;
            case 2:
                can1.sprite = dolukalp;
                can2.sprite = boskalp;
                can3.sprite = boskalp;
                break;
            case 1:
                can1.sprite = yarmkalp;
                can2.sprite = boskalp;
                can3.sprite = boskalp;
                break;
            case 0:
                can1.sprite = boskalp;
                can2.sprite = boskalp;
                can3.sprite = boskalp;
                break;

        }
    }
    public void elmassayisi()
    {
        
        elmastxt.text = Levelmangacer.toplananelmassayisi.ToString();
    }
    public void siyahekran()
    {
        sahnebit.GetComponent<CanvasGroup>().DOFade(1f, 0.75f);
    }
}
