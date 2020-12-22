using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jadibiya : MonoBehaviour {

	// Use this for initialization
	Rigidbody2D gm;
	public  bool t;
	void Start () {
		t = false;
		gm = GameObject.FindGameObjectWithTag ("Player").GetComponent<Rigidbody2D>();
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			t = true;


		}

	}
	void Update () {
		if (t) {
			gm.gravityScale = 0;
			gm.AddForce (new Vector2(0,2));
		}
	}
	void OnTriggerExit2D(Collider2D other)
	{


		if (other.tag == "Player") {

			gm.gravityScale = 2;
			t = false;

		}
	}
}
