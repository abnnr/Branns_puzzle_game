using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Helicopter : MonoBehaviour
{
	
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position = new Vector3 (transform.position.x, transform.position.z, transform.position.y + 0.2f);
		transform.eulerAngles = new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z + 5f);

	}
}

