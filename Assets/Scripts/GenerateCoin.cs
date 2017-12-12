using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCoin : MonoBehaviour
{
    public GameObject coin;

    void Start()
    {   // Startzeit: 2.5s (nach den Plants), Wiederholung alle 3s
        InvokeRepeating("CreateCoin", 2.5f, 3f);
    }
    void CreateCoin()
    {   // instantiate Coin-Prefab 
        Instantiate(coin);
    }
}
