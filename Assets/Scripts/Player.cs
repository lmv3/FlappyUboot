using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;



public class Player : MonoBehaviour
{
	// The force which is added when the player jumps
	// This can be changed in the Inspector window
	public Vector2 jumpForce = new Vector2(0, 200);
	public static int count = 0;
    public Text score;


		void Start(){

			//Getting the name of the active scene to store its name in a variable. By this it's possible to set the score on the load of the MainMenu to 0
			Scene currentScene = SceneManager.GetActiveScene();
			string sceneName = currentScene.name;
			//resetting the score at the start of every new round
			if (sceneName == "FlappyUboot"){
				count = 0; 
				SetScoreText();
			}
			else {
				SetScoreText();
			}
			//SetScoreText();
		}


    // Update is called once per frame
    void FixedUpdate ()
	{
		//Update the currently displayed count by calling the SetCountText function.
		SetScoreText();

		// Jump
		if (Input.GetKeyDown(KeyCode.Z))
		{
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			GetComponent<Rigidbody2D>().AddForce(jumpForce);
		}
		if (Input.GetKeyDown(KeyCode.M))
		{
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			GetComponent<Rigidbody2D>().AddForce(-jumpForce);
		}

	}


    //OnTriggerEnter2D is called whenever this object overlaps with a trigger collider.
    void OnTriggerEnter2D(Collider2D other)
    {
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("PickUp"))

            //... then set the other object we just collided with to inactive.
            Destroy(other.gameObject);
			//play the Coin-Sound
			FindObjectOfType<AudioManager>().Play("Coin");

        //Add one to the current value of our count variable.
        count = count + 1;
    }

    //Method to display the actual score
		void SetScoreText(){
			score.text = "Score: " + count.ToString();
		}




    //Die by collosion
    void OnCollisionEnter2D(Collision2D other)
	{
        if (other.gameObject.CompareTag("Obstacle"))
		//play the Death-Sound
		   FindObjectOfType<AudioManager>().Play("Death");
           Die();
	}
	void Die()
	{
        SceneManager.LoadScene("GameOver");
	}
}
