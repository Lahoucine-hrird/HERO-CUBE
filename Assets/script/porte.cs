using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class porte : MonoBehaviour {

	// Use this for initialization
	void Start () {
		sir = false;
	}

	bool sir;

	void OnTriggerEnter2D(Collider2D cld)
	{

		if (cld.tag == "Player") {

			sir = true;

		}
	}


	Animator an;
	public GameObject ba;
	// Update is called once per frame

	// Update is called once per frame
	void Update () {

		if (sir ) {

			Destroy (ba);
			gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
		}
	}
}
