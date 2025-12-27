using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D temasEden)
    {
        if (temasEden.CompareTag("Player"))
        {
            PlayerController oyuncu = temasEden.GetComponent<PlayerController>();
            if (oyuncu != null)
            {
                oyuncu.AltiniKazan();
                Destroy(gameObject);
            }

        }
    }
}
