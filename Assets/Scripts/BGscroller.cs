using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BGscroller : MonoBehaviour
{
    public float speed;
    Vector3 startPOS;



    void Start()
    {
        startPOS = transform.position;
    }

    void Update()
    {
        transform.Translate((new Vector3(-1, 0, 0)) * speed * Time.deltaTime);

        if (transform.position.x < -19.09307f)
        {
            transform.position = startPOS;
        }

    }
}