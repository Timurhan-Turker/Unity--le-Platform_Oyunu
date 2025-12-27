using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [Header("Cüzdan ve Skor")]
    public int ToplamAltin = 0;
    public Text AltinYazisi;
    
    [Header("Hareket Ayarlarý")]
    public float KosmaHizi = 8f;
    public float ZiplamaGucu = 20f;

    [Header("Zemin Kontrol Sensörü")]
    public Transform ZeminKontrolNoktasi;
    public float KontrolYaricapi = 0.3f;
    public LayerMask ZeminKatmani;

    private Rigidbody2D rb;
    private Animator anim;
    private bool yerdeMi;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        yerdeMi = Physics2D.OverlapCircle(ZeminKontrolNoktasi.position, KontrolYaricapi, ZeminKatmani);
        
        float hareketYon = Input.GetAxis("Horizontal");
        float gecerliKosmaHizi = KosmaHizi;
        if (!yerdeMi) 
        {
            gecerliKosmaHizi = KosmaHizi * 0.5f; 
        }
        rb.velocity = new Vector2(hareketYon * gecerliKosmaHizi, rb.velocity.y);
        
        if (Input.GetButtonDown("Jump") && yerdeMi)
        {
            rb.velocity = new Vector2(rb.velocity.x, ZiplamaGucu);
        }

        anim.SetBool("Kosuyor", Mathf.Abs(hareketYon) > 0.1f);
        anim.SetBool("Yerde", yerdeMi);
        anim.SetFloat("DikeyHiz", rb.velocity.y);
        if (hareketYon > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (hareketYon < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    public void AltiniKazan()
    {
        ToplamAltin++;
        if (AltinYazisi != null)
        {
            AltinYazisi.text = "Altýn: " + ToplamAltin.ToString();
        }
    
    }
}
