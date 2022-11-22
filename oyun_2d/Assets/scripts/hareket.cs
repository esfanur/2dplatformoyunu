using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    [SerializeField]
    float harekethiz;
    [SerializeField]
    float ziplama;
    Rigidbody2D rb;
    bool yerdemi;
    public Transform zemin;
    public LayerMask zeminlayer;
    bool ikinciziplama = false;
    Animator anim;
    public float havayziplama;

    public bool hareketesinmi;
    // Start is called before the first frame update
    private void Start()
    {
        hareketesinmi = true;
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
   
    }

    // Update is called once per frame
    void Update()
    {
        if(hareketesinmi)
        {
            hareketfonk();
            ziplamafonk();
            yondegis();
        }
        else
        {
            rb.velocity = Vector2.zero;
            anim.SetFloat("harekethiz", Mathf.Abs(rb.velocity.x));
           

        }
            
        
    

    }
   public void hareketfonk()
    {
        float h = Input.GetAxis("Horizontal");
        float hiz = h * harekethiz;
        rb.velocity = new Vector2(hiz, rb.velocity.y);
        
    }
    void ziplamafonk()
    {
        yerdemi = Physics2D.OverlapCircle(zemin.position, .2f, zeminlayer);
        if(yerdemi)
        {
            ikinciziplama = true;
        }
        if (Input.GetButtonDown("Jump"))
        {
            if(yerdemi)
            {
                rb.velocity = new Vector2(rb.velocity.x, ziplama);
                sesolaylari.olay.sesefectcal(3);
            }
            else
            {
                if(ikinciziplama==true)
                {
                    rb.velocity = new Vector2(rb.velocity.x, ziplama);
                    ikinciziplama = false;
                    sesolaylari.olay.sesefectcal(3);
                }
                    
            }
        }
        //sesolaylari.olay.sesefectcal(3);

        anim.SetFloat("harekethiz",Mathf.Abs(rb.velocity.x));
        anim.SetBool("yerdemi", yerdemi);
        
    }
    void yondegis()
    {
        Vector2 yeniscale = transform.localScale;

        if (rb.velocity.x > 0)
            yeniscale.x = 1f;
        else if (rb.velocity.x < 0)
            yeniscale.x = -1f;

        transform.localScale = yeniscale;
    }
    public void kurbagazipla()
    {
        rb.velocity = new Vector2(rb.velocity.x, havayziplama);
    }
}
