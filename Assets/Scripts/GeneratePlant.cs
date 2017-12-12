
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePlant : MonoBehaviour
{
    public GameObject plant;
    public GameObject plantTop;

    void Start()
    {
        // Startzeit: 1s , Wiederholung: alle 3s
        InvokeRepeating("CreateObstacle", 1f, 3f);
        
    }
    void CreateObstacle()
    {   
        // Positionen für Plants zufällig generieren
        float Ybottom = Random.Range(-7f, -2.05f);
        float Ytop = Random.Range(2.05f, 7f);
        float dist = Ytop - Ybottom;
        // wenn Abstand zu klein > Anpassen
        if (dist < 7)
        {
            Ybottom = Ybottom - ((7 - dist)/2);
            Ytop = Ytop + ((7 - dist)/2);
        }
        // instentiate untere Plant
        Instantiate(plant, new Vector3(10,Ybottom,0), Quaternion.identity);
        // instentiate obere Plant
        Instantiate(plantTop, new Vector3(10, Ytop, 0), Quaternion.Euler(180f,0f,0f));

    }
}
