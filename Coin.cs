using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		GameManager.totalCoinCount++;
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void OnCollisionEnter()
	{
		Debug.Log ("coin collision");
	}
	
	void OnTriggerEnter(Collider coinTriggerCollider)
		
	{
		if (coinTriggerCollider.gameObject.tag == "Player")
		{
			GameManager.totalCoinCount--;
			GameManager.score = GameManager.score + 5;;
			Destroy (gameObject);
			//Debug.Log ("coin trigger");
		}


	}
}
