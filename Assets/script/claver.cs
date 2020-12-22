using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class claver : MonoBehaviour {

	// Use this for initialization
	public GameObject ecronpnl;
	void Start () {
		ecronpnl.SetActive(false);
	}


	void OnTriggerEnter2D(Collider2D cld)
	{

		if (cld.tag == "Player") {
			
			Time.timeScale = 0f;
			ecronpnl.SetActive(true);

		}
	}
	public void prs(){
		ecronpnl.SetActive(false);
		Time.timeScale = 1f;

	}
	// Update is called once per frame
	void Update () {
		
	}
}
