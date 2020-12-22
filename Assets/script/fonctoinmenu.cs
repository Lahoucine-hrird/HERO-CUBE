using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fonctoinmenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		pause.SetActive (false);
		play.SetActive (true);
		starttime = Time.time;
		s = SceneManager.GetActiveScene ();
		nbtext2.SetActive (false);
		t = 0;
	}
	Scene s;

	public GameObject player;
	public Text timertixt;
	public Text nbtext;

	public GameObject nbtext2;

	float starttime;
	float t;
	// Update is called once per frame
	void Update () {
		float T = Time.time - starttime;
		string mun = ((int)T / 60).ToString ();
		string sec = (T % 60).ToString ("f2");

		timertixt.text = mun + " : " + sec;
		nbtext.text = player.GetComponent<cotrolplayer> ().nbkey.ToString();
		if (player.GetComponent<cotrolplayer> ().key) {
			t = t + Time.deltaTime;
			nbtext2.SetActive (true);
			if (t > 4f) {
				nbtext2.SetActive (false);
				player.GetComponent<cotrolplayer> ().key = false;
				t = 0;
			}
		}
	}

	public void restart(){
		//Application.LoadLevel (Application.loadedLevel);
		SceneManager.LoadScene(s.buildIndex);
	}
	public void menu(){
		//Application.LoadLevel (Application.loadedLevel);
		SceneManager.LoadScene(0);
	}
	public GameObject pause;
	public GameObject play;
	public void pausse(){
		Time.timeScale = 0;
		pause.SetActive (true);
		play.SetActive (false);
	}
	public void resum(){
		Time.timeScale = 1;
		pause.SetActive (false);
		play.SetActive (true);
	}


	public void left()
	{
		player.GetComponent<cotrolplayer> ().left ();

	}
	public void reght()
	{
		
		player.GetComponent<cotrolplayer> ().right ();

	}
	public void jump()
	{

		player.GetComponent<cotrolplayer> ().jmp ();

	}
	public void idel()
	{

		player.GetComponent<cotrolplayer> ().idel ();

	}
}
