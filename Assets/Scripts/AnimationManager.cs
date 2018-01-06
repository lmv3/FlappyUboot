using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour {

	public Animator anim;

	public bool shield_anim;
	public bool shrink_anim;
	//variable to keep track of when the ability was started the last time
	private float shrinkStart = 0f;

	//the cooldown for the ability
	private float shrinkCooldown = 6f;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		shield_anim = false;
		shrink_anim = false;
	}
	
	// Update is called once per frame
	void Update () {
		//setting copyCount to the value of the count variable which is used in the player script to track the score of the player
		int copyCount = Player.count;
		


		//Let the player shrink when the button is pressed and the player has a score which is higher or equal 5. Afterwards, decreasing the score of the player by 5
		if(Input.GetKeyDown("1") && copyCount >= 5 && shield_anim == false ){
			//checking if the cooldown is already over
			if(Time.time >  shrinkStart + shrinkCooldown){
				anim.Play("Shrink");
				Player.count = Player.count - 5;
				shrinkStart = Time.time;
			}

		}	

				//Let the player spawn a shield when the button is pressed and the player has a score which is higher or equal 5. Afterwards, decreasing the score of the player by 5
		if(Input.GetKeyDown("2") && copyCount >= 5 && shrink_anim == false ){
			//checking if the cooldown is already over
			//if(Time.time >  shrinkStart + shrinkCooldown){
				anim.Play("Shield");
				Player.count = Player.count - 5;
				//shrinkStart = Time.time;
			}
		}	
}
