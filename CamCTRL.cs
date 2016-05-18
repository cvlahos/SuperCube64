using UnityEngine;
using System.Collections;

public class CamCTRL : MonoBehaviour 
{
	public GameObject camTarget;
	Vector3 camOffset;
	public float smoothLook = 0.5f;
	private Quaternion targetLookRotation;

	// Use this for initialization
	void Start () 
	{

		camOffset = camTarget.transform.position + transform.position;

	}
	
	// Update is called once per frame
	void LateUpdate () 
	{
		transform.position = camTarget.transform.position + camOffset;
		targetLookRotation = Quaternion.LookRotation (camTarget.transform.position - transform.position);
		transform.rotation = Quaternion.Lerp (transform.rotation, targetLookRotation, smoothLook * Time.deltaTime);
	}
}
