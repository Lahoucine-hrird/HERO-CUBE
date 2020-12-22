using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enmybom : MonoBehaviour {

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		target = new Vector2 (player.transform.position.x, player.transform.position.y);
	}
	public float speed;
	Transform player;
	Vector2 target;
	// Update is called once per frame
	void Update () {
		transform.position = Vector2.MoveTowards (transform.position, target, speed * Time.deltaTime);
		if (transform.position.x == target.x && transform.position.y == target.y) {
			Destroy (gameObject);
		}
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("Player")) {
			

			GameObject.FindGameObjectWithTag ("Player").GetComponent<cotrolplayer> ().vr = true;
		}



	}

}
