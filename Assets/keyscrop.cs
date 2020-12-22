using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyscrop : MonoBehaviour {

	public GameObject nbtext2;
	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter2D(Collider2D cld)
	{

		if (cld.tag == "Player") {
			
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
