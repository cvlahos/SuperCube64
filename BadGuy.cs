using UnityEngine;
using System.Collections;

public class BadGuy : MonoBehaviour 
{
	public Transform playerTR;

	public float badGuySpeed;

	public Rigidbody playerRB;

	public float pushUPForce;
	public float pushBackForce;

	public Rigidbody badGuyRB;

	public GameObject bashEffectPrefab;

	public GameObject badGuyBlastParticlePrefab;

	Vector3 basherSpawnLocation;


	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
	

		transform.LookAt (playerTR);
		transform.Translate (0,0,badGuySpeed * Time.deltaTime);

		basherSpawnLocation = transform.position;
		basherSpawnLocation.y = basherSpawnLocation.y - 5;

	}

	void OnTriggerEnter(Collider badGuyTriggerCollider)
		
	{
		if (badGuyTriggerCollider.gameObject.tag == "LoseBox") 
		{
			transform.position = new Vector3 (playerTR.position.x, playerTR.position.y + 70, playerTR.position.z);
		}
	
		if (badGuyTriggerCollider.gameObject.tag == "Basher") 
		{
			//Debug.Log ("hit by trigger");
			Instantiate(bashEffectPrefab,basherSpawnLocation,transform.rotation);
			playerRB.AddForce(0,1000,0);
			//Destroy(gameObject);
			transform.position = new Vector3 (transform.position.x, transform.position.y - 10f, transform.position.z);
			//badGuyRB.AddForce(0,-2000,0);
			
			
		}



	}


	void OnCollisionEnter(Collision badGuyCollision)
	{

		if (badGuyCollision.gameObject.tag == "Player") 
		{
			Instantiate(badGuyBlastParticlePrefab,playerTR.position,transform.rotation);
			playerRB.AddRelativeForce(-pushBackForce,20,0);
			//Debug.Log ("hit the player");
		}

	}
	void OnParticleCollision(GameObject fireBallPrefab)
	{
		
		if (fireBallPrefab.gameObject.tag == "FireBall"); 

		{
			//Debug.Log ("badguy hit");
			//Instantiate(fireBasah,transform.position,transform.rotation);
			badGuyRB.AddRelativeForce(0f,pushUPForce * Time.deltaTime,0f);
		}
		
	}


}
