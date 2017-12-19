using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

    // Use this for initialization
    public GameObject backGround;
    void Start () {
        InvokeRepeating("CreateBackground", 1f, 3f);

    }
	
	// Update is called once per frame
	void CreateBackground () {
        Instantiate(backGround, new Vector3(10, 0, 0), Quaternion.identity);

    }
}
