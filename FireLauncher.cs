using UnityEngine;
using System.Collections;

public class FireLauncher : MonoBehaviour 
{
	public GameObject fireBallPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	
	{
		Vector3 fireLauncherLocation = transform.position;
		fireLauncherLocation.x = fireLauncherLocation.x + 8;

		if (Input.GetKeyDown(KeyCode.F)) 
		{
			Instantiate(fireBallPrefab,transform.position,transform.rotation);
		}
	}
}
