using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour {

	public Animator animator;


	//variable to keep track of when the ability was started the last time
	private float shrinkStart = 0f;

	//the cooldown for the ability
	private float shrinkCooldown = 6f;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		//setting copyCount to the value of the count variable which is used in the player script to track the score of the player
		int copyCount = Player.count;

		//timeStamp = Time.time + 6.0f;

		//Let the player shrink when the button is pressed and the player has a score which is higher or equal 5. Afterwards, decreasing the score of the player by 5
		if(Input.GetKeyDown("1") && copyCount >= 5 ){
			//checking if the cooldown is already over
			if(Time.time >  shrinkStart + shrinkCooldown){
				animator.Play("Shrink");
				Player.count = Player.count - 5;
				shrinkStart = Time.time;
			}
		}	
	}
}
