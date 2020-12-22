using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menupins : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public GameObject gm;
	public GameObject bgm;
	public void play(){
		//Application.LoadLevel (Application.loadedLevel);
		Instantiate(gm,bgm.transform.position,Quaternion.identity);
		SceneManager.LoadScene("level1");

	}
}
