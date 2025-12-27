using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Karakter;
    public float TakipHizi = 0.125f;
    public Vector3 Mesafe;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    void LateUpdate()
    {
        if (Karakter == null) return;

        Vector3 istenenPozisyon = Karakter.position + Mesafe;
        Vector3 yumusakGecis = Vector3.Lerp(transform.position, istenenPozisyon, TakipHizi);
        transform.position = yumusakGecis;
    }
}
