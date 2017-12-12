using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Plant : MonoBehaviour
{
    // x = Geschwindigkeit
    public Vector2 velocity = new Vector2(-4, 0);
    //Timer fuer SelfDestroy
    public float lifeTime = 4;
  
    void Start()
    {
        
        GetComponent<Rigidbody2D>().velocity = velocity;
        // Plants nach 4 Sekunden löschen, wenn außerhalb der Kamera
        Destroy(this.gameObject, lifeTime);
    }
}