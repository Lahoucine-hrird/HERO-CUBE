using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerEnter2D(Collider2D cld)
	{
		if (cld.tag == "player") {
			Destroy (gameObject);
		}

	}
	// Update is called once per frame
	void Update () {
		
	}
}
