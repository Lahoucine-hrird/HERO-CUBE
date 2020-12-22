using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fakh : MonoBehaviour {

	public GameObject bab;

	void OnTriggerEnter2D(Collider2D cld)
	{
		
		if (i == 0) {
			
				bab.transform.position = new Vector3 (bab.transform.position.x, bab.transform.position.y - 6f, bab.transform.position.z);
			


		}
		i++;
	}
	int i;
	// Use this for initialization
	void Start () {
		i = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
