using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;



public class Player : MonoBehaviour
{
	// The force which is added when the player jumps
	// This can be changed in the Inspector window
	public Vector2 jumpForce = new Vector2(0, 300);
    private int count;
    public Text score;


		void Start(){
			count = 0;
			SetScoreText();
		}


    // Update is called once per frame
    void Update ()
	{
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

        //Add one to the current value of our count variable.
        count = count + 1;

        //Update the currently displayed count by calling the SetCountText function.
        SetScoreText();
    }

    //Method to display the actual score
		void SetScoreText(){
			score.text = "Score: " + count.ToString();
		}




    //Die by collosion
    void OnCollisionEnter2D(Collision2D other)
	{
        if (other.gameObject.CompareTag("Obstacle"))

           Die();
	}
	void Die()
	{
        SceneManager.LoadScene("FlappyUboot");
	}
}
