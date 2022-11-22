using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankhareket : MonoBehaviour
{
    [SerializeField]
    Transform tankobje;

    public Animator anim;

    public enum tankdurumlari {atesetme,darbealma,hareketetme,sonaerdi};
    public tankdurumlari gecerlidurum;
    public float harekethizi;
    public Transform saghedef, solhedef;
    bool yonusagmi;

    public GameObject mermi;
    public Transform mermicikisyeri;
    public float mermiAtmasuresi;
    float mermiatmasayac;

    public Transform mayinbirakmanaoktasi;
    public GameObject mayinobje;
    public float mayinbirakmasuresi;
    float mayinsayaci;


    public float darbesuresi;
    float darbesayaci;

    [Header("candurumu")]
    public float candurum = 5;
    public GameObject tankpatlamaefect;
    bool yenildimi;
    public float mermisuresiartir, mayinbirakmaartir;


    private void Awake()
    {
       
    }

    private void Start()
    {
        gecerlidurum = tankdurumlari.atesetme;
       
        yonusagmi = true;
    }
    private void Update()
    {
        switch(gecerlidurum)
        {
            case tankdurumlari.atesetme:
                
                mermiatmasayac -= Time.deltaTime;
                if(mermiatmasayac<=0)
                {
                    mermiatmasayac = mermiAtmasuresi;
                   var yenimermi= Instantiate(mermi, mermicikisyeri.position, mermicikisyeri.rotation);
                    yenimermi.transform.localScale = tankobje.localScale;
                 
                }
                //ates etme olayýnda gerceklesicek olaylar
                break;
            case tankdurumlari.darbealma:
                if(darbesayaci>0)
                {
                    darbesayaci -= Time.deltaTime;
                    if(darbesayaci<=0)
                    {
                        gecerlidurum = tankdurumlari.hareketetme;
                        mayinsayaci = 0;
                        if(yenildimi)
                        {
                            tankobje.gameObject.SetActive(false);
                            Instantiate(tankpatlamaefect, transform.position, transform.rotation);
                            gecerlidurum = tankdurumlari.sonaerdi;
                        }
                    }
                }
                //darbe alma olayýnda gerceklesýcek olaylar
                break;
            case tankdurumlari.hareketetme:
                if(yonusagmi)
                {
                    tankobje.position += new Vector3(harekethizi*Time.deltaTime, 0f, 0f);
                    if(tankobje.position.x>saghedef.position.x)
                    {
                        tankobje.localScale = Vector3.one;
                        yonusagmi = false;
                        gecerlidurum = tankdurumlari.atesetme;
                        mermiatmasayac = mermiAtmasuresi;
                        anim.SetTrigger("hareketdurdur");
                    }
                    
                }
                else
                {
                    tankobje.position -= new Vector3(harekethizi * Time.deltaTime, 0f, 0f);
                    if (tankobje.position.x <= solhedef.position.x)
                    {
                        tankobje.localScale = new Vector3(-1f, 1f, 1f);
                        yonusagmi = true;
                        gecerlidurum = tankdurumlari.atesetme;
                        mermiatmasayac = mermiAtmasuresi;
                        anim.SetTrigger("hareketdurdur");
                    }
                }
                mayinsayaci -= Time.deltaTime;
                if(mayinsayaci<=0)
                {
                    mayinsayaci = mayinbirakmasuresi;
                    Instantiate(mayinobje, mayinbirakmanaoktasi.position, mayinbirakmanaoktasi.rotation);
                }
                //hakerek durumlarýnda gerceklesýcek olaylar
                break;

        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            darbealfnk();
        }

    }
   public void darbealfnk()
    {
        gecerlidurum = tankdurumlari.darbealma;
        darbesayaci = darbesuresi;
        anim.SetTrigger("vurma");

        bombaolay[] bombalar = FindObjectsOfType<bombaolay>();

        if(bombalar.Length>0)
        {
            foreach (bombaolay bulunanmayin in bombalar)
            {
                bulunanmayin.bombafonk();
                
            }
        }
        candurum --;
        if(candurum<=0)
        {
            yenildimi = true;
            
        }
        else
        {
            mayinbirakmasuresi /= mayinbirakmaartir;
            mermiAtmasuresi /= mermisuresiartir;
        }
       
    }
}
