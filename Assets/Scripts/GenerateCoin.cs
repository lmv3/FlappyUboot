using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCoin : MonoBehaviour
{
    public GameObject coin;

    public float start;
    public float repeat;
    void Start()
    {   // Startzeit: 2.5s (nach den Plants), Wiederholung alle 3s
        InvokeRepeating("CreateCoin", start, repeat);
    }
    void CreateCoin()
    {   // instantiate Coin-Prefab 
        Instantiate(coin);
    }
}
