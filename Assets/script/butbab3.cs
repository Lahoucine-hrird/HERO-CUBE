using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butbab3 : MonoBehaviour {

	// Use this for initialization
	public GameObject bab;
	public GameObject jadibia;
	public GameObject jadibi2;

	public ParticleSystem ps;
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("Player")) {
			Destroy (bab);
			Destroy (jadibia);
			Destroy (jadibi2);

			gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
			ps.Play ();
		}



	}

	void Start () {
		ps.Stop ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
