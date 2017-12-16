using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour {

	// Update is called once per frame
	void Update () {

		//hitting Space makes us start the game
		if (Input.GetKeyUp("space")){
			SceneManager.LoadScene("FlappyUboot");
				
		}
		//hitting escape closes the game
		if (Input.GetKeyUp("escape")){
			Application.Quit();
		}
	}
}
