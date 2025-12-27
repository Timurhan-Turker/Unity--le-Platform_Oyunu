using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class WinScreenManager : MonoBehaviour
{
    public void AnaMenuyeDon()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Ana Menüye dönülüyor...");
    }
}
