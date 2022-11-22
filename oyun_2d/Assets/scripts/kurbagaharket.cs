using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kurbagaharket : MonoBehaviour
{
    public float harekethizi;

    public Transform solhedef, saghedef;

     public SpriteRenderer sr;
    bool sagtaraf;
    Rigidbody2D rb;
    public float hareketsuresi,beklemesuresi;
    float beklemesayaci, hareketsayaci;
   public  Animator anim;
    private void Awake()
    {
       
        rb = GetComponent<Rigidbody2D>();
      
    }
    private void Start()
    {
        solhedef.parent = null; //parentten cýkarýyoruz
        saghedef.parent = null;
        sagtaraf = true;
        hareketsayaci = hareketsuresi;
    }
    private void Update()
    {
        if (hareketsayaci >= 0)
        {
            hareketsayaci -= Time.deltaTime;
            if (sagtaraf)
            {
                rb.velocity = new Vector2(harekethizi, rb.velocity.y);
                sr.flipX = true;
                if (transform.position.x > saghedef.position.x)
                {
                    sagtaraf = false;

                }
            }

            else
            {
                rb.velocity = new Vector2(-harekethizi, rb.velocity.y);
                sr.flipX = false;
                if (transform.position.x < solhedef.position.x)
                {
                    sagtaraf = true;

                }

            }
            if(hareketsayaci<=0)
            {
                beklemesayaci = Random.Range(beklemesuresi*0.5f,beklemesuresi*1.5f);
            }
            anim.SetBool("hareketediyor", true);
        }
        else if(beklemesayaci>=0)
        {
            beklemesayaci -= Time.deltaTime;
            rb.velocity = new Vector2(0, rb.velocity.y);
            if(beklemesayaci<=0)
            {
                hareketsayaci = Random.Range(hareketsuresi * 0.5f, hareketsuresi * 1.5f);
            }
            anim.SetBool("hareketediyor", false);
        }
        
    }

    
}
