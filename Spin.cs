using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour 
{
	public float spinSpeedX;
	public float spinSpeedY;
	public float spinSpeedZ;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate (spinSpeedX, spinSpeedY, spinSpeedZ);
	}
}
