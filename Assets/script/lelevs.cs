using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lelevs : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//PlayerPrefs.SetInt ("level",0);
		levelreachd = PlayerPrefs.GetInt ("level");
	}
	[Range(0,4)]
	public int levelreachd;
	public Button[] levelbuttons=new Button[4];
	public Image[] image=new Image[4];
	// Update is called once per frame
	void Update () {
		for (int i = 0; i <= levelreachd; i++) {
			levelbuttons [i].interactable = true;

		}
		for (int i = 0; i <= levelreachd; i++) {
			image [i].enabled = false;

		}
	}
}
