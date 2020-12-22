using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spoinprbm : MonoBehaviour {
	public GameObject firstpoint;
	public List<GameObject> vft = new List<GameObject> ();

	private GameObject effectspwn;
	// Use this for initialization
	void Start () {
		effectspwn = vft [0];
	}


	// Update is called once per frame
	/*void Update () {
		if (Input.GetMouseButton (0)) {
			if(firstpoint!=null)
				vft = Instantiate (effectspwn, firstpoint.transform.position, Quaternion.identity);
		}
	
	}	*/
}
