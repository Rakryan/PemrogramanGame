using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan6 : MonoBehaviour
{
    int[] intArray; // Deklarasi Array
    // Use This for initialization
    void Start()
    {
        intArray = new int[4]; //inisialisasi array
        intArray[0] = 10;
        intArray[1] = 20;
        intArray[2] = 30;
        intArray[3] = 40;
        Debug.Log("Menampilkan Seluruh Array");
        foreach (int a in intArray)
        {
            Debug.Log(a);
        }
        Debug.Log("Nilai Index ke 2 adalah " + intArray[2]);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
