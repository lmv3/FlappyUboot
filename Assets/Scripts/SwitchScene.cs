using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour {

	// Update is called once per frame
	void Update () {

		//Press any Button to start another round
		if (KutiInput.GetKutiButtonDown(EKutiButton.P1_MID) | KutiInput.GetKutiButtonDown(EKutiButton.P2_MID) | KutiInput.GetKutiButtonDown(EKutiButton.P1_LEFT) | KutiInput.GetKutiButtonDown(EKutiButton.P2_LEFT) | KutiInput.GetKutiButtonDown(EKutiButton.P1_RIGHT) | KutiInput.GetKutiButtonDown(EKutiButton.P2_RIGHT)){
			SceneManager.LoadScene("FlappyUboot");
				
		}
		//hitting escape closes the game...for testing in Unity
		if (Input.GetKeyDown("escape")){
			Application.Quit();
		}
	}
}
