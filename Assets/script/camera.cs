 using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class camera : MonoBehaviour {

	public GameObject player;

	public Vector3 offct;
	// Use this for initialization
	void Start () {
		Vector3 tmp = player.transform.position;

		transform.position = tmp+offct;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
			

		Vector3 tmp = player.transform.position;

		transform.position = tmp+offct;
	}
}
