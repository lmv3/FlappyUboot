
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePlant : MonoBehaviour
{   
    //Liste für Prefabs für Oben und Unten
    List<GameObject> topList = new List<GameObject>();
    List<GameObject> bottomList = new List<GameObject>();

    public GameObject plant;
    public GameObject plantTop;
    public GameObject RedPlant;
    public GameObject RedPlantTop;
    public GameObject VioletPlant;
    public GameObject VioletPLantTop;


    // Mindestabstand
    public float minDist = 8; 

    void Start()
    {
        //Listen füllen
        topList.Add(plantTop);
        topList.Add(RedPlantTop);
        topList.Add(VioletPLantTop);
        bottomList.Add(plant);
        bottomList.Add(RedPlant);
        bottomList.Add(VioletPlant);


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
        if (dist < minDist)
        {
            Ybottom = Ybottom - ((minDist - dist)/2);
            Ytop = Ytop + ((minDist - dist)/2);
        }
        // instentiate untere Plant
        int bottomIndex = UnityEngine.Random.Range(0, 3);
        Instantiate(bottomList[bottomIndex], new Vector3(10,Ybottom,0), Quaternion.identity);
        // instentiate obere Plant
        int topIndex = UnityEngine.Random.Range(0, 3);
        Instantiate(topList[topIndex], new Vector3(10, Ytop, 0), Quaternion.Euler(180f,0f,0f));

    }
}
