using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coin : MonoBehaviour
{    
    // x = Geschwindigkeit
    public Vector2 velocity = new Vector2(-4, 0);
    //Timer fuer SelfDestroy
    public float lifeTime = 5;


    
    void Start()
    {
        // Geschwindigkeit und Position (Random auf Y-Achse) für Coin
        GetComponent<Rigidbody2D>().velocity = velocity;
        transform.position = new Vector3(10, Random.Range(-3.5f, 3.5f), transform.position.z);
        // Coin nach 5 Sekunden löschen, wenn außerhalb der Kamera
        Destroy(this.gameObject, lifeTime);
    }
}