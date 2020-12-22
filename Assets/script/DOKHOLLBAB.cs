using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOKHOLLBAB : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public AudioSource bab;
	void OnTriggerEnter2D(Collider2D cld)
	{

		if (cld.tag == "Player") {
			bab.Play();


		}
	}
}
