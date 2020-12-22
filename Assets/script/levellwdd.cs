using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levellwdd : MonoBehaviour {

	public Slider slider;

	// Use this for initialization
	public void LoadLevel()
	{
		StartCoroutine (LoadAsynchronously (1));


		 
	}
	public void quit()
	{
		Application.Quit ();
	}
	void Start () {
		gm.SetActive(false);
		lodiscr.SetActive (false);

	}
	public GameObject gm;
	public void stng()
	{
		//SceneManager.LoadScene("level1");
		gm.SetActive(true);

	}
	public void ferstng()
	{
		//SceneManager.LoadScene("level1");
		gm.SetActive(false);

	}
	public GameObject pnl;
	public GameObject pnl1;
	public GameObject pnl2;
	public GameObject lodiscr;

	IEnumerator LoadAsynchronously(int sceneundex){
		pnl.SetActive (false);
		gm.SetActive(false);

		pnl1.SetActive (false);
		pnl2.SetActive (false);
		lodiscr.SetActive (true);
		AsyncOperation opiration = SceneManager.LoadSceneAsync (sceneundex);


		while(opiration.isDone==false){

			float progg = Mathf.Clamp01 (opiration.progress / 0.9f);
			slider.value = progg;

			yield return null;
		}
	}




}
