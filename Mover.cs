using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour 
{
	public Transform playerCubeTR;
	public Transform moverTR;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

void OnTriggerEnter(Collider moverTrigCol)
	{
		if (moverTrigCol.gameObject.tag == "ForMover") 
		{
			playerCubeTR.parent = moverTR;
		}
	}

	void OnTriggerExit(Collider moverTrigCol)
	{
		if (moverTrigCol.gameObject.tag == "ForMover") 
		{
			playerCubeTR.parent = null;
		}
	}

}
