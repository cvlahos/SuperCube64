using UnityEngine;
using System.Collections;

public class FireBall: MonoBehaviour 
{
	//public float fireballSpeed;



	//public BadGuy badGuyScript;

	// Use this for initialization
	void Start () 
	{
		Destroy (gameObject,3f);
	}
	
	// Update is called once per frame
	void Update () 
	{

		//transform.Translate(0,0,fireballSpeed * Time.deltaTime);
	}



}