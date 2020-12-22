using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movplat : MonoBehaviour {

	// Use this for initialization
	void Start () {
		sir = false;

		an = plt.GetComponent<Animator> ();
	
	}

	bool sir;

	public GameObject plt;


	void OnTriggerEnter2D(Collider2D cld)
	{

		if (cld.tag == "pltmov") {

			sir = true;

		}
	}


	Animator an;

	// Update is called once per frame
	void Update () {
		
		if (sir ) {
			an.SetBool ("hl", true);


		}


	}
}
