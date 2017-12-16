using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Switch_MainMenu : MonoBehaviour {

	// Update is called once per frame
	void Update () {

		//hitting Space is returning the player to the MainMenu
		if (Input.GetKeyUp("space")){
			SceneManager.LoadScene("MainMenu");
				
		}
	}
}
