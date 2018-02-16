using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour {

	public Color cubecolor = new Color();
	public Renderer cuberenderer;
	public GameObject player;
	public float lerpstrength;

	// Use this for initialization
	void Start () {
		//cuberenderer.material.color = cubecolor;
	}
	
	// Update is called once per frame
	void Update () {
		//verandert kleur gebaseerd op afstand. getyped door iemand anders
		cubecolor = new Color (cubecolor.r, Vector3.Distance (transform.position, player.transform.position) / lerpstrength, Vector3.Distance (transform.position, player.transform.position) / lerpstrength);
		cuberenderer.material.color = cubecolor;
	}
}
