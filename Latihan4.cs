using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan4 : MonoBehaviour
{
    Karakter player1;
    // Use this for initialization
    void Start()
    {
        player1 = new Karakter();
        player1.Name = "Dio";
        player1.Health = 100;
        player1.Damage = 30;
        //Menampilkan hasil dari Inisialisasi attribute.
        Debug.Log("Name:" + player1.Name + ",Health: " + player1.Health + ",Damage: " + player1.Damage);
        // memanggil method dari salah satu method class Karakter.

        player1.Jump();
    }
    //Update Is called once per frame
    void Update()
    {
        
    }
}
