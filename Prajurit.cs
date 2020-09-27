using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prajurit : Manusia
{
    private void Start()
    {
        Debug.Log("Seorang Prajurit dapat:");
        Makan();
        Tidur();
        Menyerang();
    }
    void Update()
    {
        
    }
    void Menyerang()
    {
        Debug.Log("Menyerang");
    }
}