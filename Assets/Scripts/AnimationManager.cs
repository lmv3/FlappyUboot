using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour {

	public Animator anim;

	//these variable are public so that they can be accessed by the animation
	public bool shield_anim;
	public bool shrink_anim;
	//variables to keep track of when the ability was started the last time
	private float shrinkStart = 0f;
	private float shieldStart = 0f;

	//the cooldown for the abilities
	private float shrinkCooldown = 6f;
	private float shieldCooldown = 6f;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();

		//both are set to false in the beginning so that you can start an ability for the first time
		shield_anim = false;
		shrink_anim = false;
	}
	
	// Update is called once per frame
	void Update () {
		//setting copyCount to the value of the count variable which is used in the player script to track the score of the player
		int copyCount = Player.count;
		


		//Let the player shrink when the button is pressed and the player has a score which is higher or equal 5. Afterwards, decreasing the score of the player by 5
		//the last part checks if the other shield is currently used
		if(Input.GetKeyDown("1") && Input.GetKeyDown("q") && copyCount >= 5 && shield_anim == false ){
			//checking if the cooldown is already over
			if(Time.time >  shrinkStart + shrinkCooldown){
				anim.Play("Shrink");
				Player.count = Player.count - 5;
				shrinkStart = Time.time;
			}

		}	

				//Let the player spawn a shield when the button is pressed and the player has a score which is higher or equal 5. Afterwards, decreasing the score of the player by 5
				//the last part checks if the other shrink is currently used
		if(Input.GetKeyDown("2") && copyCount >= 5 && shrink_anim == false ){
			//checking if the cooldown is already over
			if(Time.time >  shieldStart + shieldCooldown){
				anim.Play("Shield");
				Player.count = Player.count - 5;
				shieldStart = Time.time;
			}
		}	
	}
}
