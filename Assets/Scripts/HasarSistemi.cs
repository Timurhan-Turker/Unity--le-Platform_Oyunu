using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HasarSistemi : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Tuzaða deðen þey oyuncu mu?
        if (other.CompareTag("Player"))
        {
            Debug.Log("Tuzaða bastýn! Level yeniden baþlýyor...");

            // Mevcut sahneyi tekrar yükle (Restart mantýðý)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
