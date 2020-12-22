using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class retat : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public float speed;
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3(transform.rotation.x,transform.rotation.y,Time.deltaTime*speed*-1));
	}
}
