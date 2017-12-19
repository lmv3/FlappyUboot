using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

	private static MusicPlayer _instance;

	void Awake(){
		DontDestroyOnLoad(this.gameObject);

		if(GameObject.Find(gameObject.name) && GameObject.Find(gameObject.name) != this.gameObject){
			Destroy(GameObject.Find(gameObject.name));
		}
	}
}
