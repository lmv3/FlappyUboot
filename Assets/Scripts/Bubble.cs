using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bubble : MonoBehaviour
{
    // x = Geschwindigkeit
    public Vector2 velocity = new Vector2(-4, 0);
    //Timer fuer SelfDestroy
    public float lifeTime = 4;



    void Start()
    {
        // Geschwindigkeit und Position (Random auf Y-Achse) für Coin
        GetComponent<Rigidbody2D>().velocity = velocity;
        transform.position = new Vector3(20, transform.position.y, transform.position.z);
        // Coin nach 4 Sekunden löschen, wenn außerhalb der Kamera
        Destroy(this.gameObject, lifeTime);
    }
}