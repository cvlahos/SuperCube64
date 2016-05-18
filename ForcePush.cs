using UnityEngine;
using System.Collections;

public class ForcePush : MonoBehaviour 
{
	//public Transform playerTr;
	public Rigidbody playerRB;

	public float forceUP;
	public float forceX;
	public float forceZ;

	//public ParticleSystem particle;
	

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
	
		
	
		
		//transform.position += transform.forward * Time.deltaTime;
	}
	
	void OnTriggerEnter(Collider col)
	{
		
		if (col.gameObject.tag == "Player") 
		{
			//particle.Play();
			playerRB.AddForce(forceX,forceUP,forceZ);
			
		}

		
	}
	

}
