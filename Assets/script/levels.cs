using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class levels : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public Slider slider;

	public void level1(int sceneindex)
	{
		//SceneManager.LoadScene("level1");
		StartCoroutine (LoadAsynchronously (sceneindex));

	}
	public GameObject pnl;
	public GameObject lodiscr;

	IEnumerator LoadAsynchronously(int sceneundex){
		pnl.SetActive (false);
		lodiscr.SetActive (true);
		AsyncOperation opiration = SceneManager.LoadSceneAsync (sceneundex);


		while(opiration.isDone==false){

			float progg = Mathf.Clamp01 (opiration.progress / 0.9f);
			slider.value = progg;

			yield return null;
		}
	}
}
