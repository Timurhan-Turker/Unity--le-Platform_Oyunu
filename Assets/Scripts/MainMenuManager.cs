using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    private const int LEVEL_1_INDEX = 1;

    // BURAYI KONTROL ET! Mutlaka 'public' yazmalýdýr.
    public void StartGame()
    {
        SceneManager.LoadScene(LEVEL_1_INDEX);
        Debug.Log("Oyun Baþlatýldý: Level 1 yükleniyor.");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Oyundan çýkýþ yapýldý.");
    }
}