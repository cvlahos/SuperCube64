using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour 
{
	public float speed;
	public float turnSpeed;
	public float jumpSpeed;

	public Rigidbody playerRB;

	bool isOnThePlatform;
	

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update()
	{

	}
	void FixedUpdate () 
	{
		//Debug.Log (isOnThePlatform);

		if (Input.GetKey (KeyCode.UpArrow)) 
		{
			transform.Translate(speed * Time.deltaTime,0,0);
			//playerRB.AddRelativeForce(speed * Time.deltaTime,0,0);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			transform.Rotate (0, turnSpeed, 0);
		}


		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			transform.Rotate (0, -turnSpeed, 0);
		}



		if (Input.GetKeyDown (KeyCode.Space) && isOnThePlatform == true) 
		{
			playerRB.AddForce(0,jumpSpeed,0);
		}
	}


	void OnCollisionEnter (Collision platformEnterCol)
	{
		if (platformEnterCol.gameObject.tag == "Platform") 
		{
			isOnThePlatform = true;
		}
	}

	void OnCollisionExit (Collision platformExitCol)
	{
		if (platformExitCol.gameObject.tag == "Platform") 
		{
			isOnThePlatform = false;
		}
	}

}
