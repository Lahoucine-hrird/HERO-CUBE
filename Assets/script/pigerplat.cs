using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pigerplat : MonoBehaviour {

	// Use this for initialization
	public GameObject pl58;
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag("Player"))
			pl58.GetComponent<Rigidbody2D> ().simulated = true;
	}
	// Update is called once per frame
	void start(){
		pl58.GetComponent<Rigidbody2D> ().simulated = false;
	}
	void Update () {
		

	}
}
