using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class BitisEkraniKontrol : MonoBehaviour
{
    void Update()
    {
        // Eðer ENTER tuþuna basýlýrsa oyunu (Level 1'i) yeniden baþlat
        if (Input.GetKeyDown(KeyCode.Return))
        {
            // Buradaki "1" senin oyun sahnenin numarasý olmalý
            SceneManager.LoadScene(1);
        }

        // Eðer ESC tuþuna basýlýrsa oyunu kapat
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Oyundan Çýkýldý!");
            Application.Quit();
        }
    }
}