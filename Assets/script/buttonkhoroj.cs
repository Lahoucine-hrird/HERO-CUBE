using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonkhoroj : MonoBehaviour {
	public Vector2 v;
	public GameObject ba;

	bool prs;
	public AudioSource bab;
	void OnTriggerEnter2D(Collider2D cld)
	{

		if (cld.tag == "Player") {

			prs = true;
			bab.Play ();
		}
	}
	// Use this for initialization
	void Start () {
		prs = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (prs == true) {
			Destroy (ba);
			gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
		}
	}}

